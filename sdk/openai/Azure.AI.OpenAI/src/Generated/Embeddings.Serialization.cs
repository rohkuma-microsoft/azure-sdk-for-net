// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class Embeddings : IUtf8JsonSerializable, IJsonModel<Embeddings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Embeddings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Embeddings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Embeddings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Embeddings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("usage"u8);
            writer.WriteObjectValue(Usage);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        Embeddings IJsonModel<Embeddings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Embeddings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Embeddings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEmbeddings(document.RootElement, options);
        }

        internal static Embeddings DeserializeEmbeddings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<EmbeddingItem> data = default;
            EmbeddingsUsage usage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    List<EmbeddingItem> array = new List<EmbeddingItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EmbeddingItem.DeserializeEmbeddingItem(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    usage = EmbeddingsUsage.DeserializeEmbeddingsUsage(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Embeddings(data, usage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Embeddings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Embeddings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Embeddings)} does not support '{options.Format}' format.");
            }
        }

        Embeddings IPersistableModel<Embeddings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Embeddings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEmbeddings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Embeddings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Embeddings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Embeddings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEmbeddings(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
