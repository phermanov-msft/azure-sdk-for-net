// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ScVmm.Models
{
    /// <summary> Specifies the vmmServer infrastructure specific settings for the virtual machine instance for update. </summary>
    internal partial class ScVmmInfrastructureProfileUpdate
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

        /// <summary> Initializes a new instance of <see cref="ScVmmInfrastructureProfileUpdate"/>. </summary>
        public ScVmmInfrastructureProfileUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmInfrastructureProfileUpdate"/>. </summary>
        /// <param name="checkpointType"> Type of checkpoint supported for the vm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmInfrastructureProfileUpdate(string checkpointType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CheckpointType = checkpointType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of checkpoint supported for the vm. </summary>
        public string CheckpointType { get; set; }
    }
}
