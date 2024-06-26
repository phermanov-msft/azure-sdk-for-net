// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.CodeTransparency
{
    /// <summary> The Response body of the GetOperationId API. </summary>
    public partial class GetOperationResult
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

        /// <summary> Initializes a new instance of <see cref="GetOperationResult"/>. </summary>
        /// <param name="operationId"> OperationId. </param>
        /// <param name="status"> Status of the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        internal GetOperationResult(string operationId, OperationStatus status)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));

            OperationId = operationId;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="GetOperationResult"/>. </summary>
        /// <param name="entryId"> ID of the transaction. Only if status is Succeeded. </param>
        /// <param name="error"> Error in json format. Only if Status is Failed. </param>
        /// <param name="operationId"> OperationId. </param>
        /// <param name="status"> Status of the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetOperationResult(string entryId, string error, string operationId, OperationStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EntryId = entryId;
            Error = error;
            OperationId = operationId;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetOperationResult"/> for deserialization. </summary>
        internal GetOperationResult()
        {
        }

        /// <summary> ID of the transaction. Only if status is Succeeded. </summary>
        public string EntryId { get; }
        /// <summary> Error in json format. Only if Status is Failed. </summary>
        public string Error { get; }
        /// <summary> OperationId. </summary>
        public string OperationId { get; }
        /// <summary> Status of the operation. </summary>
        public OperationStatus Status { get; }
    }
}
