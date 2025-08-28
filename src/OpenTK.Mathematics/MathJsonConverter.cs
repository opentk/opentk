using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenTK.Mathematics
{
    internal enum ComponentType
    {
        Float,
        Double,
        Int,
        Bool,
    }

    public class MathJsonConverter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)] T, TComp> : JsonConverter<T> where T : struct where TComp : struct
    {
        private static readonly FieldInfo[] _fields;
        private static readonly byte[][] _fieldNames;

        public static bool IsSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (typeof(T) == typeof(Vector2))
                    || (typeof(T) == typeof(Vector2d))
                    || (typeof(T) == typeof(Vector2h))
                    || (typeof(T) == typeof(Vector2i))
                    || (typeof(T) == typeof(Vector2b));
            }
        }

        static MathJsonConverter()
        {
            Debug.Assert(typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Length == 0, "Cannot contain non-public fields.");
            _fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Instance);

            _fieldNames = new byte[_fields.Length][];
            for (int i = 0; i < _fields.Length; i++)
            {
                if (_fields[i].FieldType != typeof(TComp))
                {
                    throw new NotSupportedException("Wrong component type!");
                }

                _fieldNames[i] = Encoding.UTF8.GetBytes(_fields[i].Name);
            }

            if (IsSupported == false)
            {
                throw new NotSupportedException();
            }
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw CreateUnexpectedException(ref reader, "{");
            }
            reader.Read();

            T value = default;
            TypedReference valueRef = __makeref(value);
            for (int i = 0; i < _fields.Length; i++)
            {
                _fields[i].SetValueDirect(valueRef, ReadProperty(ref reader, _fieldNames[i]));
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.EndObject)
            {
                throw CreateUnexpectedException(ref reader, "}");
            }

            return value;
        }

        // FIXME: Move to extension?
        private static TComp ReadProperty(ref Utf8JsonReader reader, ReadOnlySpan<byte> utf8Name)
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
            if (typeof(TComp) == typeof(bool))
            {
                if (reader.TokenType != JsonTokenType.True &&
                    reader.TokenType != JsonTokenType.False)
                {
                    throw CreateUnexpectedException(ref reader, "number");
                }
                return ReadComponentValue(ref reader);
            }
            else
            {
                if (reader.TokenType != JsonTokenType.Number)
                {
                    throw CreateUnexpectedException(ref reader, "number");
                }
                return ReadComponentValue(ref reader);
            }
        }

        private static TComp ReadComponentValue(ref Utf8JsonReader reader)
        {
            if (typeof(TComp) == typeof(float))
            {
                if (reader.TryGetSingle(out float value) == false)
                {
                    throw new JsonException();
                }
                reader.Read();
                return (TComp)(object)value;
            }
            else if (typeof(TComp) == typeof(double))
            {
                if (reader.TryGetDouble(out double value) == false)
                {
                    throw new JsonException();
                }
                reader.Read();
                return (TComp)(object)value;
            }
            else if (typeof(TComp) == typeof(Half))
            {
                if (reader.TryGetSingle(out float value) == false)
                {
                    throw new JsonException();
                }
                reader.Read();
                return (TComp)(object)(Half)value;
            }
            else if (typeof(TComp) == typeof(int))
            {
                if (reader.TryGetInt32(out int value) == false)
                {
                    throw new JsonException();
                }
                reader.Read();
                return (TComp)(object)value;
            }
            else if (typeof(TComp) == typeof(bool))
            {
                bool value = reader.GetBoolean();
                reader.Read();
                return (TComp)(object)value;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            for (int i = 0; i < _fields.Length; i++)
            {
                WriteComponent(writer, _fieldNames[i], (TComp)_fields[i].GetValue(value));
            }
            writer.WriteEndObject();
        }

        private static void WriteComponent(Utf8JsonWriter writer, ReadOnlySpan<byte> utf8Name, TComp value)
        {
            if (typeof(TComp) == typeof(float))
            {
                writer.WriteNumber(utf8Name, (float)(object)value);
            }
            else if (typeof(TComp) == typeof(double))
            {
                writer.WriteNumber(utf8Name, (double)(object)value);
            }
            else if (typeof(TComp) == typeof(Half))
            {
                writer.WriteNumber(utf8Name, (float)(Half)(object)value);
            }
            else if (typeof(TComp) == typeof(int))
            {
                writer.WriteNumber(utf8Name, (int)(object)value);
            }
            else if (typeof(TComp) == typeof(bool))
            {
                writer.WriteBoolean(utf8Name, (bool)(object)value);
            }
            else
            {
                throw new NotSupportedException();
            }
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
