// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP configuration of an Bastion Host. </summary>
    public partial class BastionHostIPConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of BastionHostIPConfiguration. </summary>
        public BastionHostIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of BastionHostIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="subnet"> Reference of the subnet resource. </param>
        /// <param name="publicIPAddress"> Reference of the PublicIP resource. </param>
        /// <param name="provisioningState"> The provisioning state of the bastion host IP configuration resource. </param>
        /// <param name="privateIPAllocationMethod"> Private IP allocation method. </param>
        internal BastionHostIPConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, WritableSubResource subnet, WritableSubResource publicIPAddress, NetworkProvisioningState? provisioningState, IPAllocationMethod? privateIPAllocationMethod) : base(id, name, resourceType)
        {
            ETag = eTag;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Reference of the subnet resource. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> Reference of the PublicIP resource. </summary>
        internal WritableSubResource PublicIPAddress { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPAddressId
        {
            get => PublicIPAddress is null ? default : PublicIPAddress.Id;
            set
            {
                if (PublicIPAddress is null)
                    PublicIPAddress = new WritableSubResource();
                PublicIPAddress.Id = value;
            }
        }

        /// <summary> The provisioning state of the bastion host IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Private IP allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
    }
}
