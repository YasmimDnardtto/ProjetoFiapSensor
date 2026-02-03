using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TalhaoSensorApi.JsonConverters
{
    public class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        private const string DateFormat = "yyyy-MM-dd";

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (string.IsNullOrEmpty(s))
            {
                throw new JsonException("Expected date string in format 'yyyy-MM-dd'.");
            }

            if (DateOnly.TryParseExact(s, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var d))
            {
                return d;
            }

            if (DateOnly.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.None, out var d2))
            {
                return d2;
            }

            throw new JsonException($"Could not parse date '{s}'. Expected format 'yyyy-MM-dd'.");
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(DateFormat, CultureInfo.InvariantCulture));
        }
    }
}