// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The URL to download the generated report. </summary>
    public partial class DownloadURL
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

        /// <summary> Initializes a new instance of <see cref="DownloadURL"/>. </summary>
        internal DownloadURL()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DownloadURL"/>. </summary>
        /// <param name="expiryOn"> The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z. </param>
        /// <param name="validTill"> The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z. </param>
        /// <param name="downloadUri"> The URL to download the generated report. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DownloadURL(DateTimeOffset? expiryOn, DateTimeOffset? validTill, Uri downloadUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpiryOn = expiryOn;
            ValidTill = validTill;
            DownloadUri = downloadUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z. </summary>
        public DateTimeOffset? ExpiryOn { get; }
        /// <summary> The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z. </summary>
        public DateTimeOffset? ValidTill { get; }
        /// <summary> The URL to download the generated report. </summary>
        public Uri DownloadUri { get; }
    }
}
