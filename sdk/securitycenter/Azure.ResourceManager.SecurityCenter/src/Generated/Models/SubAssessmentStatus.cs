// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Status of the sub-assessment. </summary>
    public partial class SubAssessmentStatus
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

        /// <summary> Initializes a new instance of <see cref="SubAssessmentStatus"/>. </summary>
        public SubAssessmentStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubAssessmentStatus"/>. </summary>
        /// <param name="code"> Programmatic code for the status of the assessment. </param>
        /// <param name="cause"> Programmatic code for the cause of the assessment status. </param>
        /// <param name="description"> Human readable description of the assessment status. </param>
        /// <param name="severity"> The sub-assessment severity level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubAssessmentStatus(SubAssessmentStatusCode? code, string cause, string description, SecurityAssessmentSeverity? severity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Cause = cause;
            Description = description;
            Severity = severity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Programmatic code for the status of the assessment. </summary>
        public SubAssessmentStatusCode? Code { get; }
        /// <summary> Programmatic code for the cause of the assessment status. </summary>
        public string Cause { get; }
        /// <summary> Human readable description of the assessment status. </summary>
        public string Description { get; }
        /// <summary> The sub-assessment severity level. </summary>
        public SecurityAssessmentSeverity? Severity { get; }
    }
}
