
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanFiles.Utils
{
    using System;
    using System.Globalization;
    using System.Numerics;
    using Newtonsoft.Json;

    internal class BigIntSerializer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            var  nullableType = Nullable.GetUnderlyingType(objectType);
            if (nullableType != null)
            {
                return nullableType == typeof(BigInteger);
            }

            return objectType == typeof(BigInteger);
        }

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
                return null;
            }

            try {
                return BigInteger.Parse(reader.Value.ToString()!);
            } catch (System.FormatException ex) {
                throw new Newtonsoft.Json.JsonSerializationException("Could not parse BigInteger", ex);
            }
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteValue("null");
                return;
            }

            writer.WriteValue(((BigInteger)value).ToString(CultureInfo.InvariantCulture));
        }
    }
}
