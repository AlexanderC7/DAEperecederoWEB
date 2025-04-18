using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DateTimeArrayConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException("Se esperaba un array para la fecha.");
        }

        // Leer los componentes de la fecha
        reader.Read(); int year = reader.GetInt32();
        reader.Read(); int month = reader.GetInt32();
        reader.Read(); int day = reader.GetInt32();
        reader.Read(); int hour = reader.GetInt32();
        reader.Read(); int minute = reader.GetInt32();
        reader.Read(); int second = reader.GetInt32();

        reader.Read(); // Final del array

        return new DateTime(year, month, day, hour, minute, second);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.Year);
        writer.WriteNumberValue(value.Month);
        writer.WriteNumberValue(value.Day);
        writer.WriteNumberValue(value.Hour);
        writer.WriteNumberValue(value.Minute);
        writer.WriteNumberValue(value.Second);
        writer.WriteEndArray();
    }
}
