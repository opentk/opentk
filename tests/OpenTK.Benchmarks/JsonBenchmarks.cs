using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenTK.Benchmarks
{
    [SimpleJob(RuntimeMoniker.Net80)]
    public class JsonBenchmarks
    {
        private readonly Vector2JsonConverter Vec2Converter = new Vector2JsonConverter();
        private readonly MathJsonConverter<Vector2, float> MathConverter = new MathJsonConverter<Vector2, float>();
        private readonly JsonSerializerOptions Options = new JsonSerializerOptions();

        private static readonly string JsonString = """{"X": 10, "Y": 20}""";

        [BenchmarkCategory("Write")]
        [Benchmark]
        public string WriteVector2ThroughSerializer()
        {
            return JsonSerializer.Serialize(new Vector2(1, 2), Options);
        }

        [BenchmarkCategory("Write")]
        [Benchmark]
        public void WriteVector2Direct()
        {
            Utf8JsonWriter writer = new Utf8JsonWriter(Stream.Null);
            Vec2Converter.Write(writer, new Vector2(1, 2), Options);
        }

        [BenchmarkCategory("Write")]
        [Benchmark]
        public void WriteVector2Generic()
        {
            Utf8JsonWriter writer = new Utf8JsonWriter(Stream.Null);
            MathConverter.Write(writer, new Vector2(1, 2), Options);
        }

        [BenchmarkCategory("Write")]
        [Benchmark]
        public void WriteVector2TextWriter()
        {
            Vector2 val = new Vector2(1, 2);
            StreamWriter writer = new StreamWriter(Stream.Null);
            writer.Write($"{{\"X\": {val.X}, \"Y\": {val.Y}}}");
        }

        [BenchmarkCategory("Read")]
        [Benchmark]
        public Vector2 ReadVector2ThroughSerializer()
        {
            return JsonSerializer.Deserialize<Vector2>(JsonString, Options);
        }

        [BenchmarkCategory("Read")]
        [Benchmark]
        public Vector2 ReadVector2Direct()
        {
            byte[] utf8 = Encoding.UTF8.GetBytes(JsonString);
            Utf8JsonReader reader = new Utf8JsonReader(utf8);
            reader.Read();
            return Vec2Converter.Read(ref reader, typeof(Vector2), Options);
        }

        [BenchmarkCategory("Read")]
        [Benchmark]
        public Vector2 ReadVector2Generic()
        {
            byte[] utf8 = Encoding.UTF8.GetBytes(JsonString);
            Utf8JsonReader reader = new Utf8JsonReader(utf8);
            reader.Read();
            return MathConverter.Read(ref reader, typeof(Vector2), Options);
        }
    }

    internal class Vector2JsonConverter : JsonConverter<Vector2>
    {
        public override Vector2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw CreateUnexpectedException(ref reader, "{");
            }
            reader.Read();

            Vector2 value = default;
            value.X = ReadProperty(ref reader, "X"u8);
            value.Y = ReadProperty(ref reader, "Y"u8);

            reader.Read();
            if (reader.TokenType != JsonTokenType.EndObject)
            {
                throw CreateUnexpectedException(ref reader, "}");
            }

            return value;
        }

        // FIXME: Move to extension?
        private static float ReadProperty(ref Utf8JsonReader reader, ReadOnlySpan<byte> utf8Name)
        {
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw CreateUnexpectedException(ref reader, utf8Name);
            }

            if (reader.ValueTextEquals(utf8Name) == false)
            {
                throw CreateUnexpectedException(ref reader, utf8Name);
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw CreateUnexpectedException(ref reader, "number");
            }
            return ReadComponentValue(ref reader);
        }

        private static float ReadComponentValue(ref Utf8JsonReader reader)
        {
            if (reader.TryGetSingle(out float value) == false)
            {
                throw new JsonException();
            }
            reader.Read();
            return value;
        }

        public override void Write(Utf8JsonWriter writer, Vector2 value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("X"u8, value.X);
            writer.WriteNumber("Y"u8, value.Y);
            writer.WriteEndObject();
        }

        private static FormatException CreateUnexpectedException(ref Utf8JsonReader reader, string expected)
        {
            // Replace with public API once https://github.com/dotnet/runtime/issues/28482 is fixed
            object boxedState = reader.CurrentState;
            long lineNumber = (long)(typeof(JsonReaderState).GetField("_lineNumber", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(boxedState) ?? -1);
            long bytePositionInLine = (long)(typeof(JsonReaderState).GetField("_bytePositionInLine", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(boxedState) ?? -1);

            return new FormatException($"Unexpected character encountered, excepted '{expected}' " +
                                       $"at line {lineNumber} position {bytePositionInLine}");
        }

        private static FormatException CreateUnexpectedException(ref Utf8JsonReader reader, ReadOnlySpan<byte> expected)
        {
            // Replace with public API once https://github.com/dotnet/runtime/issues/28482 is fixed
            object boxedState = reader.CurrentState;
            long lineNumber = (long)(typeof(JsonReaderState).GetField("_lineNumber", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(boxedState) ?? -1);
            long bytePositionInLine = (long)(typeof(JsonReaderState).GetField("_bytePositionInLine", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(boxedState) ?? -1);

            return new FormatException($"Unexpected character encountered, excepted '{Encoding.UTF8.GetString(expected)}' " +
                                       $"at line {lineNumber} position {bytePositionInLine}");
        }
    }
}
