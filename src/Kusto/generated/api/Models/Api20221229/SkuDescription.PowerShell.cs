// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>The Kusto SKU description of given resource type</summary>
    [System.ComponentModel.TypeConverter(typeof(SkuDescriptionTypeConverter))]
    public partial class SkuDescription
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.SkuDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescription" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescription DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SkuDescription(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.SkuDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescription" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescription DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SkuDescription(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SkuDescription" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SkuDescription" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescription FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.SkuDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SkuDescription(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Tier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Tier = (string) content.GetValueForProperty("Tier",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Tier, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Location = (string[]) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Location, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).LocationInfo = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuLocationInfoItem[]) content.GetValueForProperty("LocationInfo",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).LocationInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuLocationInfoItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.SkuLocationInfoItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("Restriction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Restriction = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.IAny[]) content.GetValueForProperty("Restriction",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Restriction, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.AnyTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.SkuDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SkuDescription(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Tier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Tier = (string) content.GetValueForProperty("Tier",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Tier, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Location = (string[]) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Location, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).LocationInfo = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuLocationInfoItem[]) content.GetValueForProperty("LocationInfo",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).LocationInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuLocationInfoItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.SkuLocationInfoItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("Restriction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Restriction = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.IAny[]) content.GetValueForProperty("Restriction",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.ISkuDescriptionInternal)this).Restriction, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.AnyTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The Kusto SKU description of given resource type
    [System.ComponentModel.TypeConverter(typeof(SkuDescriptionTypeConverter))]
    public partial interface ISkuDescription

    {

    }
}