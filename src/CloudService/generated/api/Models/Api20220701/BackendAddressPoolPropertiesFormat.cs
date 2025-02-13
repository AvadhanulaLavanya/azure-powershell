// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Properties of the backend address pool.</summary>
    public partial class BackendAddressPoolPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="BackendIPConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] _backendIPConfiguration;

        /// <summary>An array of references to IP addresses defined in network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] BackendIPConfiguration { get => this._backendIPConfiguration; }

        /// <summary>Backing field for <see cref="DrainPeriodInSecond" /> property.</summary>
        private int? _drainPeriodInSecond;

        /// <summary>
        /// Amount of seconds Load Balancer waits for before sending RESET to client and backend address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public int? DrainPeriodInSecond { get => this._drainPeriodInSecond; set => this._drainPeriodInSecond = value; }

        /// <summary>Backing field for <see cref="InboundNatRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] _inboundNatRule;

        /// <summary>An array of references to inbound NAT rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] InboundNatRule { get => this._inboundNatRule; }

        /// <summary>Backing field for <see cref="LoadBalancerBackendAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] _loadBalancerBackendAddress;

        /// <summary>An array of backend addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] LoadBalancerBackendAddress { get => this._loadBalancerBackendAddress; set => this._loadBalancerBackendAddress = value; }

        /// <summary>Backing field for <see cref="LoadBalancingRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] _loadBalancingRule;

        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] LoadBalancingRule { get => this._loadBalancingRule; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location of the backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for BackendIPConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal.BackendIPConfiguration { get => this._backendIPConfiguration; set { {_backendIPConfiguration = value;} } }

        /// <summary>Internal Acessors for InboundNatRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal.InboundNatRule { get => this._inboundNatRule; set { {_inboundNatRule = value;} } }

        /// <summary>Internal Acessors for LoadBalancingRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal.LoadBalancingRule { get => this._loadBalancingRule; set { {_loadBalancingRule = value;} } }

        /// <summary>Internal Acessors for OutboundRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal.OutboundRule { get => (this._outboundRule = this._outboundRule ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); set { {_outboundRule = value;} } }

        /// <summary>Internal Acessors for OutboundRules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal.OutboundRules { get => this._outboundRules; set { {_outboundRules = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IBackendAddressPoolPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="OutboundRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated _outboundRule;

        /// <summary>A reference to an outbound rule that uses this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated OutboundRule { get => (this._outboundRule = this._outboundRule ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.SubResourceAutoGenerated()); }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string OutboundRuleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)OutboundRule).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGeneratedInternal)OutboundRule).Id = value ?? null; }

        /// <summary>Backing field for <see cref="OutboundRules" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] _outboundRules;

        /// <summary>An array of references to outbound rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] OutboundRules { get => this._outboundRules; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the backend address pool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="TunnelInterface" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] _tunnelInterface;

        /// <summary>An array of gateway load balancer tunnel interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] TunnelInterface { get => this._tunnelInterface; set => this._tunnelInterface = value; }

        /// <summary>Creates an new <see cref="BackendAddressPoolPropertiesFormat" /> instance.</summary>
        public BackendAddressPoolPropertiesFormat()
        {

        }
    }
    /// Properties of the backend address pool.
    public partial interface IBackendAddressPoolPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>An array of references to IP addresses defined in network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to IP addresses defined in network interfaces.",
        SerializedName = @"backendIPConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] BackendIPConfiguration { get;  }
        /// <summary>
        /// Amount of seconds Load Balancer waits for before sending RESET to client and backend address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Amount of seconds Load Balancer waits for before sending RESET to client and backend address.",
        SerializedName = @"drainPeriodInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? DrainPeriodInSecond { get; set; }
        /// <summary>An array of references to inbound NAT rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to inbound NAT rules that use this backend address pool.",
        SerializedName = @"inboundNatRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] InboundNatRule { get;  }
        /// <summary>An array of backend addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of backend addresses.",
        SerializedName = @"loadBalancerBackendAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] LoadBalancerBackendAddress { get; set; }
        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to load balancing rules that use this backend address pool.",
        SerializedName = @"loadBalancingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] LoadBalancingRule { get;  }
        /// <summary>The location of the backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the backend address pool.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string OutboundRuleId { get; set; }
        /// <summary>An array of references to outbound rules that use this backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to outbound rules that use this backend address pool.",
        SerializedName = @"outboundRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] OutboundRules { get;  }
        /// <summary>The provisioning state of the backend address pool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the backend address pool resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>An array of gateway load balancer tunnel interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of gateway load balancer tunnel interfaces.",
        SerializedName = @"tunnelInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] TunnelInterface { get; set; }

    }
    /// Properties of the backend address pool.
    internal partial interface IBackendAddressPoolPropertiesFormatInternal

    {
        /// <summary>An array of references to IP addresses defined in network interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceIPConfiguration[] BackendIPConfiguration { get; set; }
        /// <summary>
        /// Amount of seconds Load Balancer waits for before sending RESET to client and backend address.
        /// </summary>
        int? DrainPeriodInSecond { get; set; }
        /// <summary>An array of references to inbound NAT rules that use this backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] InboundNatRule { get; set; }
        /// <summary>An array of backend addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress[] LoadBalancerBackendAddress { get; set; }
        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] LoadBalancingRule { get; set; }
        /// <summary>The location of the backend address pool.</summary>
        string Location { get; set; }
        /// <summary>A reference to an outbound rule that uses this backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated OutboundRule { get; set; }
        /// <summary>Resource ID.</summary>
        string OutboundRuleId { get; set; }
        /// <summary>An array of references to outbound rules that use this backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated[] OutboundRules { get; set; }
        /// <summary>The provisioning state of the backend address pool resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>An array of gateway load balancer tunnel interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IGatewayLoadBalancerTunnelInterface[] TunnelInterface { get; set; }

    }
}