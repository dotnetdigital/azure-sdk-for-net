﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.KeyVault.Tests
{
    [NonParallelizable]
    public class PrivateEndpointConnectionTests : VaultOperationsTestsBase
    {
        public PrivateEndpointConnectionTests(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task ClearChallengeCacheforRecord()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await Initialize().ConfigureAwait(false);
            }
        }

        [Test]
        [RecordedTest]
        public async Task PrivateEndpointConnectionCreateAndUpdate()
        {
            IgnoreTestInLiveMode();
            /*
            CAUTION: all private endpoint methods do not work properly now, so just temporally use Network's private endpoint methods for testing.
            Will confirm service team that this is expected.
            */

            // Create a vault first
            VaultResource vaultResource = (await CreateVault()).Value;
            // Create a vnet
            VirtualNetworkResource vnetResource = (await createVirtualNetwork()).Value;

            // Create the private endpoint
            PrivateEndpointData privateEndpointData = new PrivateEndpointData
            {
                Location = Location,
                Subnet = vnetResource.Data.Subnets[0],
                ManualPrivateLinkServiceConnections = {
                    new PrivateLinkServiceConnection
                    {
                        Name = Recording.GenerateAssetName("pec"),
                        // TODO: externalize or create the service on-demand, like virtual network
                        //PrivateLinkServiceId = $"/subscriptions/{SubscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}",
                        PrivateLinkServiceId = vaultResource.Data.Id,

                        RequestMessage = "SDK test",
                        GroupIds = { "vault" }
                    }
                },
            };

            string privateEndpointName = Recording.GenerateAssetName("pe-");
            PrivateEndpointCollection privateEndpointCollection = ResourceGroupResource.GetPrivateEndpoints();
            PrivateEndpointResource privateEndpoint = (await privateEndpointCollection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointName, privateEndpointData)).Value;

            // get
            privateEndpoint = (await privateEndpointCollection.GetAsync(privateEndpointName)).Value;
            Assert.AreEqual(privateEndpoint.Data.Name, privateEndpointName);
            Assert.AreEqual(privateEndpoint.Data.Location, Location);
            Assert.IsEmpty(privateEndpoint.Data.Tags);

            // update
            privateEndpointData.Tags.Add("test", "test");
            privateEndpoint = (await privateEndpointCollection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpoint.Data.Name, privateEndpointData)).Value;
            Assert.AreEqual(privateEndpoint.Data.Name, privateEndpointName);
            Assert.AreEqual(privateEndpoint.Data.Location, Location);
            Assert.That(privateEndpoint.Data.Tags, Has.Count.EqualTo(1));
            Assert.That(privateEndpoint.Data.Tags, Does.ContainKey("test").WithValue("test"));

            // list
            List<PrivateEndpointResource> privateEndpoints = (await privateEndpointCollection.GetAllAsync().ToEnumerableAsync());
            Assert.That(privateEndpoints, Has.Count.EqualTo(1));
            Assert.AreEqual(privateEndpointName, privateEndpoint.Data.Name);

            // delete
            await privateEndpoint.DeleteAsync(WaitUntil.Completed);

            // list all
            privateEndpoints = (await Subscription.GetPrivateEndpointsAsync().ToEnumerableAsync());
            Assert.That(privateEndpoints, Has.None.Matches<PrivateEndpointResource>(p => p.Data.Name == privateEndpointName));
        }

        private async Task<ArmOperation<VirtualNetworkResource>> createVirtualNetwork()
        {
            var vnetName = Recording.GenerateAssetName("vnet-");
            var vnet = new VirtualNetworkData()
            {
                Location = Location,
                Subnets = { new SubnetData() {
                    Name = "default",
                    AddressPrefix = "10.0.1.0/24",
                    PrivateEndpointNetworkPolicy = VirtualNetworkPrivateEndpointNetworkPolicy.Disabled
                }}
            };
            vnet.AddressPrefixes.Add("10.0.0.0/16");
            vnet.DhcpOptionsDnsServers.Add("10.1.1.1");
            vnet.DhcpOptionsDnsServers.Add("10.1.2.4");
            VirtualNetworkCollection networks = ResourceGroupResource.GetVirtualNetworks();
            return await networks.CreateOrUpdateAsync(WaitUntil.Completed, vnetName, vnet);
        }

        private async Task<ArmOperation<VaultResource>> CreateVault()
        {
            // Create a Vault first
            VaultCreateOrUpdateContent parameters = new VaultCreateOrUpdateContent(Location, VaultProperties);
            parameters.Tags.InitializeFrom(Tags);
            return await VaultCollection.CreateOrUpdateAsync(WaitUntil.Completed, VaultName, parameters).ConfigureAwait(false);
        }
    }
}
