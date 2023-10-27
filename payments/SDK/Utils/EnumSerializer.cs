
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using Newtonsoft.Json;

namespace SDK.Utils
{
    internal class EnumSerializer : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.IsEnum;

        public override bool CanRead => true;

        public override object? ReadJson(
            JsonReader reader,
            Type objectType,
            object? existingValue,
            JsonSerializer serializer
        )
        {
            if (reader.Value == null)
            {
                throw new ArgumentNullException(nameof(reader.Value));
            }

            var extensionType = Type.GetType(objectType.FullName + "Extension");
            if (extensionType == null)
            {
                return Enum.ToObject(objectType, reader.Value);
            }

            var method = extensionType.GetMethod("ToEnum");
            if (method == null)
            {
                throw new Exception($"Unable to find ToEnum method on {extensionType.FullName}");
            }

            return method.Invoke(null, new[] { (string)reader.Value });
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteValue("null");
                return;
            }

            var extensionType = Type.GetType(value.GetType().FullName + "Extension");
            if (extensionType == null)
            {
                writer.WriteValue(value);
                return;
            }

            writer.WriteValue(Utilities.ToString(value));
        }
    }
}
