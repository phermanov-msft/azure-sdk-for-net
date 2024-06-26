// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> Represents the signing key. </summary>
    public partial class DnsSigningKey
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

        /// <summary> Initializes a new instance of <see cref="DnsSigningKey"/>. </summary>
        internal DnsSigningKey()
        {
            DelegationSignerInfo = new ChangeTrackingList<DelegationSignerInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsSigningKey"/>. </summary>
        /// <param name="delegationSignerInfo"> The delegation signer information. </param>
        /// <param name="flags"> The flags specifies how the key is used. </param>
        /// <param name="keyTag"> The key tag value of the DNSKEY Resource Record. </param>
        /// <param name="protocol"> The protocol value. The value is always 3. </param>
        /// <param name="publicKey"> The public key, represented as a Base64 encoding. </param>
        /// <param name="securityAlgorithmType"> The security algorithm type represents the standard security algorithm number of the DNSKEY Resource Record. See: https://www.iana.org/assignments/dns-sec-alg-numbers/dns-sec-alg-numbers.xhtml. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsSigningKey(IReadOnlyList<DelegationSignerInfo> delegationSignerInfo, int? flags, int? keyTag, int? protocol, string publicKey, int? securityAlgorithmType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DelegationSignerInfo = delegationSignerInfo;
            Flags = flags;
            KeyTag = keyTag;
            Protocol = protocol;
            PublicKey = publicKey;
            SecurityAlgorithmType = securityAlgorithmType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The delegation signer information. </summary>
        public IReadOnlyList<DelegationSignerInfo> DelegationSignerInfo { get; }
        /// <summary> The flags specifies how the key is used. </summary>
        public int? Flags { get; }
        /// <summary> The key tag value of the DNSKEY Resource Record. </summary>
        public int? KeyTag { get; }
        /// <summary> The protocol value. The value is always 3. </summary>
        public int? Protocol { get; }
        /// <summary> The public key, represented as a Base64 encoding. </summary>
        public string PublicKey { get; }
        /// <summary> The security algorithm type represents the standard security algorithm number of the DNSKEY Resource Record. See: https://www.iana.org/assignments/dns-sec-alg-numbers/dns-sec-alg-numbers.xhtml. </summary>
        public int? SecurityAlgorithmType { get; }
    }
}
