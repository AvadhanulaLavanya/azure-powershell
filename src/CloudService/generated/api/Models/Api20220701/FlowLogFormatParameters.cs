// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Parameters that define the flow log format.</summary>
    public partial class FlowLogFormatParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogFormatParameters,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogFormatParametersInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? _type;

        /// <summary>The file type of flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private int? _version;

        /// <summary>The version (revision) of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public int? Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="FlowLogFormatParameters" /> instance.</summary>
        public FlowLogFormatParameters()
        {

        }
    }
    /// Parameters that define the flow log format.
    public partial interface IFlowLogFormatParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The file type of flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The file type of flow log.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? Type { get; set; }
        /// <summary>The version (revision) of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version (revision) of the flow log.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? Version { get; set; }

    }
    /// Parameters that define the flow log format.
    internal partial interface IFlowLogFormatParametersInternal

    {
        /// <summary>The file type of flow log.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? Type { get; set; }
        /// <summary>The version (revision) of the flow log.</summary>
        int? Version { get; set; }

    }
}