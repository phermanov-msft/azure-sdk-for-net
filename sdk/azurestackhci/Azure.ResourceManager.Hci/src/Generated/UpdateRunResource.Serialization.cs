// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class UpdateRunResource : IJsonModel<UpdateRunData>
    {
        void IJsonModel<UpdateRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<UpdateRunData>)Data).Write(writer, options);

        UpdateRunData IJsonModel<UpdateRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<UpdateRunData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<UpdateRunData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        UpdateRunData IPersistableModel<UpdateRunData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<UpdateRunData>(data, options);

        string IPersistableModel<UpdateRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<UpdateRunData>)Data).GetFormatFromOptions(options);
    }
}
