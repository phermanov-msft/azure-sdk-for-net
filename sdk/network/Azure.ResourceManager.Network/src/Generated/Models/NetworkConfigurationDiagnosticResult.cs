// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network configuration diagnostic result corresponded to provided traffic query. </summary>
    public partial class NetworkConfigurationDiagnosticResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticResult"/>. </summary>
        internal NetworkConfigurationDiagnosticResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticResult"/>. </summary>
        /// <param name="profile"> Network configuration diagnostic profile. </param>
        /// <param name="networkSecurityGroupResult"> Network security group result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkConfigurationDiagnosticResult(NetworkConfigurationDiagnosticProfile profile, NetworkSecurityGroupResult networkSecurityGroupResult, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Profile = profile;
            NetworkSecurityGroupResult = networkSecurityGroupResult;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Network configuration diagnostic profile. </summary>
        public NetworkConfigurationDiagnosticProfile Profile { get; }
        /// <summary> Network security group result. </summary>
        public NetworkSecurityGroupResult NetworkSecurityGroupResult { get; }
    }
}
