// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListOutboundRule API service call. </summary>
    internal partial class LoadBalancerOutboundRuleListResult
    {
        /// <summary> Initializes a new instance of LoadBalancerOutboundRuleListResult. </summary>
        internal LoadBalancerOutboundRuleListResult()
        {
            Value = new ChangeTrackingList<OutboundRule>();
        }

        /// <summary> Initializes a new instance of LoadBalancerOutboundRuleListResult. </summary>
        /// <param name="value"> A list of outbound rules in a load balancer. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal LoadBalancerOutboundRuleListResult(IReadOnlyList<OutboundRule> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of outbound rules in a load balancer. </summary>
        public IReadOnlyList<OutboundRule> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
