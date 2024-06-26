// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing the MediaLiveOutput data model.
    /// The Live Output.
    /// </summary>
    public partial class MediaLiveOutputData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MediaLiveOutputData"/>. </summary>
        public MediaLiveOutputData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveOutputData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the live output. </param>
        /// <param name="assetName"> The asset that the live output will write to. </param>
        /// <param name="archiveWindowLength"> ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window. </param>
        /// <param name="rewindWindowLength"> ISO 8601 time between 1 minute to the duration of archiveWindowLength to control seek-able window length during Live. The service won't use this property once LiveOutput stops. The archived VOD will have full content with original ArchiveWindowLength. For example, use PT1H30M to indicate 1 hour and 30 minutes of rewind window length. Service will use implicit default value 30m only if Live Event enables LL. </param>
        /// <param name="manifestName"> The manifest file name. If not provided, the service will generate one automatically. </param>
        /// <param name="hls"> HTTP Live Streaming (HLS) packing setting for the live output. </param>
        /// <param name="outputSnapTime"> The initial timestamp that the live output will start at, any content before this value will not be archived. </param>
        /// <param name="createdOn"> The creation time the live output. </param>
        /// <param name="lastModifiedOn"> The time the live output was last modified. </param>
        /// <param name="provisioningState"> The provisioning state of the live output. </param>
        /// <param name="resourceState"> The resource state of the live output. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaLiveOutputData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string assetName, TimeSpan? archiveWindowLength, TimeSpan? rewindWindowLength, string manifestName, Hls hls, long? outputSnapTime, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string provisioningState, LiveOutputResourceState? resourceState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            AssetName = assetName;
            ArchiveWindowLength = archiveWindowLength;
            RewindWindowLength = rewindWindowLength;
            ManifestName = manifestName;
            Hls = hls;
            OutputSnapTime = outputSnapTime;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description of the live output. </summary>
        public string Description { get; set; }
        /// <summary> The asset that the live output will write to. </summary>
        public string AssetName { get; set; }
        /// <summary> ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window. </summary>
        public TimeSpan? ArchiveWindowLength { get; set; }
        /// <summary> ISO 8601 time between 1 minute to the duration of archiveWindowLength to control seek-able window length during Live. The service won't use this property once LiveOutput stops. The archived VOD will have full content with original ArchiveWindowLength. For example, use PT1H30M to indicate 1 hour and 30 minutes of rewind window length. Service will use implicit default value 30m only if Live Event enables LL. </summary>
        public TimeSpan? RewindWindowLength { get; set; }
        /// <summary> The manifest file name. If not provided, the service will generate one automatically. </summary>
        public string ManifestName { get; set; }
        /// <summary> HTTP Live Streaming (HLS) packing setting for the live output. </summary>
        internal Hls Hls { get; set; }
        /// <summary> The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output. </summary>
        public int? HlsFragmentsPerTsSegment
        {
            get => Hls is null ? default : Hls.FragmentsPerTsSegment;
            set
            {
                if (Hls is null)
                    Hls = new Hls();
                Hls.FragmentsPerTsSegment = value;
            }
        }

        /// <summary> The initial timestamp that the live output will start at, any content before this value will not be archived. </summary>
        public long? OutputSnapTime { get; set; }
        /// <summary> The creation time the live output. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the live output was last modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The provisioning state of the live output. </summary>
        public string ProvisioningState { get; }
        /// <summary> The resource state of the live output. </summary>
        public LiveOutputResourceState? ResourceState { get; }
    }
}
