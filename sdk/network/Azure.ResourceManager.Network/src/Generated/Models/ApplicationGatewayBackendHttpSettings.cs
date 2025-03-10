// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Backend address pool settings of an application gateway. </summary>
    public partial class ApplicationGatewayBackendHttpSettings : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayBackendHttpSettings. </summary>
        public ApplicationGatewayBackendHttpSettings()
        {
            AuthenticationCertificates = new ChangeTrackingList<WritableSubResource>();
            TrustedRootCertificates = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayBackendHttpSettings. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="port"> The destination port on the backend. </param>
        /// <param name="protocol"> The protocol used to communicate with the backend. </param>
        /// <param name="cookieBasedAffinity"> Cookie based affinity. </param>
        /// <param name="requestTimeoutInSeconds"> Request timeout in seconds. Application Gateway will fail the request if response is not received within RequestTimeout. Acceptable values are from 1 second to 86400 seconds. </param>
        /// <param name="probe"> Probe resource of an application gateway. </param>
        /// <param name="authenticationCertificates"> Array of references to application gateway authentication certificates. </param>
        /// <param name="trustedRootCertificates"> Array of references to application gateway trusted root certificates. </param>
        /// <param name="connectionDraining"> Connection draining of the backend http settings resource. </param>
        /// <param name="hostName"> Host header to be sent to the backend servers. </param>
        /// <param name="pickHostNameFromBackendAddress"> Whether to pick host header should be picked from the host name of the backend server. Default value is false. </param>
        /// <param name="affinityCookieName"> Cookie name to use for the affinity cookie. </param>
        /// <param name="probeEnabled"> Whether the probe is enabled. Default value is false. </param>
        /// <param name="path"> Path which should be used as a prefix for all HTTP requests. Null means no path will be prefixed. Default value is null. </param>
        /// <param name="provisioningState"> The provisioning state of the backend HTTP settings resource. </param>
        internal ApplicationGatewayBackendHttpSettings(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, int? port, ApplicationGatewayProtocol? protocol, ApplicationGatewayCookieBasedAffinity? cookieBasedAffinity, int? requestTimeoutInSeconds, WritableSubResource probe, IList<WritableSubResource> authenticationCertificates, IList<WritableSubResource> trustedRootCertificates, ApplicationGatewayConnectionDraining connectionDraining, string hostName, bool? pickHostNameFromBackendAddress, string affinityCookieName, bool? probeEnabled, string path, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = eTag;
            Port = port;
            Protocol = protocol;
            CookieBasedAffinity = cookieBasedAffinity;
            RequestTimeoutInSeconds = requestTimeoutInSeconds;
            Probe = probe;
            AuthenticationCertificates = authenticationCertificates;
            TrustedRootCertificates = trustedRootCertificates;
            ConnectionDraining = connectionDraining;
            HostName = hostName;
            PickHostNameFromBackendAddress = pickHostNameFromBackendAddress;
            AffinityCookieName = affinityCookieName;
            ProbeEnabled = probeEnabled;
            Path = path;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The destination port on the backend. </summary>
        public int? Port { get; set; }
        /// <summary> The protocol used to communicate with the backend. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> Cookie based affinity. </summary>
        public ApplicationGatewayCookieBasedAffinity? CookieBasedAffinity { get; set; }
        /// <summary> Request timeout in seconds. Application Gateway will fail the request if response is not received within RequestTimeout. Acceptable values are from 1 second to 86400 seconds. </summary>
        public int? RequestTimeoutInSeconds { get; set; }
        /// <summary> Probe resource of an application gateway. </summary>
        internal WritableSubResource Probe { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ProbeId
        {
            get => Probe is null ? default : Probe.Id;
            set
            {
                if (Probe is null)
                    Probe = new WritableSubResource();
                Probe.Id = value;
            }
        }

        /// <summary> Array of references to application gateway authentication certificates. </summary>
        public IList<WritableSubResource> AuthenticationCertificates { get; }
        /// <summary> Array of references to application gateway trusted root certificates. </summary>
        public IList<WritableSubResource> TrustedRootCertificates { get; }
        /// <summary> Connection draining of the backend http settings resource. </summary>
        public ApplicationGatewayConnectionDraining ConnectionDraining { get; set; }
        /// <summary> Host header to be sent to the backend servers. </summary>
        public string HostName { get; set; }
        /// <summary> Whether to pick host header should be picked from the host name of the backend server. Default value is false. </summary>
        public bool? PickHostNameFromBackendAddress { get; set; }
        /// <summary> Cookie name to use for the affinity cookie. </summary>
        public string AffinityCookieName { get; set; }
        /// <summary> Whether the probe is enabled. Default value is false. </summary>
        public bool? ProbeEnabled { get; set; }
        /// <summary> Path which should be used as a prefix for all HTTP requests. Null means no path will be prefixed. Default value is null. </summary>
        public string Path { get; set; }
        /// <summary> The provisioning state of the backend HTTP settings resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
