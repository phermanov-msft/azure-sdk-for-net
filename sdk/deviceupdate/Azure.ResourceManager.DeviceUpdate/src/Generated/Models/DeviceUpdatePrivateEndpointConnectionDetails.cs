// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private endpoint connection proxy object properties. </summary>
    public partial class DeviceUpdatePrivateEndpointConnectionDetails
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

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateEndpointConnectionDetails"/>. </summary>
        public DeviceUpdatePrivateEndpointConnectionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateEndpointConnectionDetails"/>. </summary>
        /// <param name="id"> Connection details ID. </param>
        /// <param name="privateIPAddress"> Private IP address. </param>
        /// <param name="linkIdentifier"> Link ID. </param>
        /// <param name="groupId"> Group ID. </param>
        /// <param name="memberName"> Member name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceUpdatePrivateEndpointConnectionDetails(string id, string privateIPAddress, string linkIdentifier, string groupId, string memberName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            PrivateIPAddress = privateIPAddress;
            LinkIdentifier = linkIdentifier;
            GroupId = groupId;
            MemberName = memberName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Connection details ID. </summary>
        public string Id { get; }
        /// <summary> Private IP address. </summary>
        public string PrivateIPAddress { get; }
        /// <summary> Link ID. </summary>
        public string LinkIdentifier { get; }
        /// <summary> Group ID. </summary>
        public string GroupId { get; }
        /// <summary> Member name. </summary>
        public string MemberName { get; }
    }
}
