// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache Directory Services settings. </summary>
    public partial class StorageCacheDirectorySettings
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

        /// <summary> Initializes a new instance of <see cref="StorageCacheDirectorySettings"/>. </summary>
        public StorageCacheDirectorySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheDirectorySettings"/>. </summary>
        /// <param name="activeDirectory"> Specifies settings for joining the HPC Cache to an Active Directory domain. </param>
        /// <param name="usernameDownload"> Specifies settings for Extended Groups. Extended Groups allows users to be members of more than 16 groups. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheDirectorySettings(StorageCacheActiveDirectorySettings activeDirectory, StorageCacheUsernameDownloadSettings usernameDownload, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActiveDirectory = activeDirectory;
            UsernameDownload = usernameDownload;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies settings for joining the HPC Cache to an Active Directory domain. </summary>
        public StorageCacheActiveDirectorySettings ActiveDirectory { get; set; }
        /// <summary> Specifies settings for Extended Groups. Extended Groups allows users to be members of more than 16 groups. </summary>
        public StorageCacheUsernameDownloadSettings UsernameDownload { get; set; }
    }
}
