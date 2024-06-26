// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningRegistryEnvironmentVersionOperationSource : IOperationSource<MachineLearningRegistryEnvironmentVersionResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningRegistryEnvironmentVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningRegistryEnvironmentVersionResource IOperationSource<MachineLearningRegistryEnvironmentVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MachineLearningEnvironmentVersionData.DeserializeMachineLearningEnvironmentVersionData(document.RootElement);
            return new MachineLearningRegistryEnvironmentVersionResource(_client, data);
        }

        async ValueTask<MachineLearningRegistryEnvironmentVersionResource> IOperationSource<MachineLearningRegistryEnvironmentVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MachineLearningEnvironmentVersionData.DeserializeMachineLearningEnvironmentVersionData(document.RootElement);
            return new MachineLearningRegistryEnvironmentVersionResource(_client, data);
        }
    }
}
