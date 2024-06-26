// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityWorkspaceSettingResource : IJsonModel<SecurityWorkspaceSettingData>
    {
        void IJsonModel<SecurityWorkspaceSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityWorkspaceSettingData>)Data).Write(writer, options);

        SecurityWorkspaceSettingData IJsonModel<SecurityWorkspaceSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityWorkspaceSettingData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityWorkspaceSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityWorkspaceSettingData IPersistableModel<SecurityWorkspaceSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityWorkspaceSettingData>(data, options);

        string IPersistableModel<SecurityWorkspaceSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityWorkspaceSettingData>)Data).GetFormatFromOptions(options);
    }
}
