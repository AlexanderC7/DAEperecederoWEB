using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class FlexibleDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Si es string (ISO 8601)
        if (reader.TokenType == JsonTokenType.String)
        {
            var stringValue = reader.GetString();
            if (DateTime.TryParse(stringValue, out DateTime date))
            {
                return date;
            }

            throw new JsonException($"Formato de fecha inválido: {stringValue}");
        }

        // Si es array: [año, mes, día, hora, minuto] o [año, mes, día, hora, minuto, segundo]
        if (reader.TokenType == JsonTokenType.StartArray)
        {
            reader.Read(); int year = reader.GetInt32();
            reader.Read(); int month = reader.GetInt32();
            reader.Read(); int day = reader.GetInt32();
            reader.Read(); int hour = reader.GetInt32();
            reader.Read(); int minute = reader.GetInt32();

            int second = 0;

            reader.Read();
            if (reader.TokenType == JsonTokenType.Number)
            {
                second = reader.GetInt32();
                reader.Read(); // Avanza fuera del array
            }

            return new DateTime(year, month, day, hour, minute, second);
        }

        throw new JsonException("No se reconoce el formato de fecha.");
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        // Por simplicidad, lo escribe como string ISO
        writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ss"));
    }
}
