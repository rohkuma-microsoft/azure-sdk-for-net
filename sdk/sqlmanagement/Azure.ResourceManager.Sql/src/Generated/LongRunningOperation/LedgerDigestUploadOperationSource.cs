// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class LedgerDigestUploadOperationSource : IOperationSource<LedgerDigestUploadResource>
    {
        private readonly ArmClient _client;

        internal LedgerDigestUploadOperationSource(ArmClient client)
        {
            _client = client;
        }

        LedgerDigestUploadResource IOperationSource<LedgerDigestUploadResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LedgerDigestUploadData.DeserializeLedgerDigestUploadData(document.RootElement);
            return new LedgerDigestUploadResource(_client, data);
        }

        async ValueTask<LedgerDigestUploadResource> IOperationSource<LedgerDigestUploadResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LedgerDigestUploadData.DeserializeLedgerDigestUploadData(document.RootElement);
            return new LedgerDigestUploadResource(_client, data);
        }
    }
}
