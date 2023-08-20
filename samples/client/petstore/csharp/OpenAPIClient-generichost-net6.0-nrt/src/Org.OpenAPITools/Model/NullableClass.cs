// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NullableClass
    /// </summary>
    public partial class NullableClass : Dictionary<String, Object>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableClass" /> class.
        /// </summary>
        /// <param name="arrayItemsNullable">arrayItemsNullable</param>
        /// <param name="objectItemsNullable">objectItemsNullable</param>
        /// <param name="arrayAndItemsNullableProp">arrayAndItemsNullableProp</param>
        /// <param name="arrayNullableProp">arrayNullableProp</param>
        /// <param name="booleanProp">booleanProp</param>
        /// <param name="dateProp">dateProp</param>
        /// <param name="datetimeProp">datetimeProp</param>
        /// <param name="integerProp">integerProp</param>
        /// <param name="numberProp">numberProp</param>
        /// <param name="objectAndItemsNullableProp">objectAndItemsNullableProp</param>
        /// <param name="objectNullableProp">objectNullableProp</param>
        /// <param name="stringProp">stringProp</param>
        [JsonConstructor]
        public NullableClass(List<Object> arrayItemsNullable, Dictionary<string, Object> objectItemsNullable, List<Object>? arrayAndItemsNullableProp = default, List<Object>? arrayNullableProp = default, bool? booleanProp = default, DateTime? dateProp = default, DateTime? datetimeProp = default, int? integerProp = default, decimal? numberProp = default, Dictionary<string, Object>? objectAndItemsNullableProp = default, Dictionary<string, Object>? objectNullableProp = default, string? stringProp = default) : base()
        {
            ArrayItemsNullable = arrayItemsNullable;
            ObjectItemsNullable = objectItemsNullable;
            ArrayAndItemsNullableProp = arrayAndItemsNullableProp;
            ArrayNullableProp = arrayNullableProp;
            BooleanProp = booleanProp;
            DateProp = dateProp;
            DatetimeProp = datetimeProp;
            IntegerProp = integerProp;
            NumberProp = numberProp;
            ObjectAndItemsNullableProp = objectAndItemsNullableProp;
            ObjectNullableProp = objectNullableProp;
            StringProp = stringProp;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ArrayItemsNullable
        /// </summary>
        [JsonPropertyName("array_items_nullable")]
        public List<Object> ArrayItemsNullable { get; set; }

        /// <summary>
        /// Gets or Sets ObjectItemsNullable
        /// </summary>
        [JsonPropertyName("object_items_nullable")]
        public Dictionary<string, Object> ObjectItemsNullable { get; set; }

        /// <summary>
        /// Gets or Sets ArrayAndItemsNullableProp
        /// </summary>
        [JsonPropertyName("array_and_items_nullable_prop")]
        public List<Object>? ArrayAndItemsNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets ArrayNullableProp
        /// </summary>
        [JsonPropertyName("array_nullable_prop")]
        public List<Object>? ArrayNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets BooleanProp
        /// </summary>
        [JsonPropertyName("boolean_prop")]
        public bool? BooleanProp { get; set; }

        /// <summary>
        /// Gets or Sets DateProp
        /// </summary>
        [JsonPropertyName("date_prop")]
        public DateTime? DateProp { get; set; }

        /// <summary>
        /// Gets or Sets DatetimeProp
        /// </summary>
        [JsonPropertyName("datetime_prop")]
        public DateTime? DatetimeProp { get; set; }

        /// <summary>
        /// Gets or Sets IntegerProp
        /// </summary>
        [JsonPropertyName("integer_prop")]
        public int? IntegerProp { get; set; }

        /// <summary>
        /// Gets or Sets NumberProp
        /// </summary>
        [JsonPropertyName("number_prop")]
        public decimal? NumberProp { get; set; }

        /// <summary>
        /// Gets or Sets ObjectAndItemsNullableProp
        /// </summary>
        [JsonPropertyName("object_and_items_nullable_prop")]
        public Dictionary<string, Object>? ObjectAndItemsNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets ObjectNullableProp
        /// </summary>
        [JsonPropertyName("object_nullable_prop")]
        public Dictionary<string, Object>? ObjectNullableProp { get; set; }

        /// <summary>
        /// Gets or Sets StringProp
        /// </summary>
        [JsonPropertyName("string_prop")]
        public string? StringProp { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NullableClass {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ArrayItemsNullable: ").Append(ArrayItemsNullable).Append("\n");
            sb.Append("  ObjectItemsNullable: ").Append(ObjectItemsNullable).Append("\n");
            sb.Append("  ArrayAndItemsNullableProp: ").Append(ArrayAndItemsNullableProp).Append("\n");
            sb.Append("  ArrayNullableProp: ").Append(ArrayNullableProp).Append("\n");
            sb.Append("  BooleanProp: ").Append(BooleanProp).Append("\n");
            sb.Append("  DateProp: ").Append(DateProp).Append("\n");
            sb.Append("  DatetimeProp: ").Append(DatetimeProp).Append("\n");
            sb.Append("  IntegerProp: ").Append(IntegerProp).Append("\n");
            sb.Append("  NumberProp: ").Append(NumberProp).Append("\n");
            sb.Append("  ObjectAndItemsNullableProp: ").Append(ObjectAndItemsNullableProp).Append("\n");
            sb.Append("  ObjectNullableProp: ").Append(ObjectNullableProp).Append("\n");
            sb.Append("  StringProp: ").Append(StringProp).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NullableClass" />
    /// </summary>
    public class NullableClassJsonConverter : JsonConverter<NullableClass>
    {
        /// <summary>
        /// The format to use to serialize DateProp
        /// </summary>
        public static string DatePropFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize DatetimeProp
        /// </summary>
        public static string DatetimePropFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="NullableClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NullableClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<Object>? arrayItemsNullable = default;
            Dictionary<string, Object>? objectItemsNullable = default;
            List<Object>? arrayAndItemsNullableProp = default;
            List<Object>? arrayNullableProp = default;
            bool? booleanProp = default;
            DateTime? dateProp = default;
            DateTime? datetimeProp = default;
            int? integerProp = default;
            decimal? numberProp = default;
            Dictionary<string, Object>? objectAndItemsNullableProp = default;
            Dictionary<string, Object>? objectNullableProp = default;
            string? stringProp = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "array_items_nullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayItemsNullable = JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "object_items_nullable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectItemsNullable = JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "array_and_items_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayAndItemsNullableProp = JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "array_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayNullableProp = JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "boolean_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                booleanProp = utf8JsonReader.GetBoolean();
                            break;
                        case "date_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateProp = JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "datetime_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                datetimeProp = JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "integer_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                integerProp = utf8JsonReader.GetInt32();
                            break;
                        case "number_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                numberProp = utf8JsonReader.GetDecimal();
                            break;
                        case "object_and_items_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectAndItemsNullableProp = JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "object_nullable_prop":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                objectNullableProp = JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "string_prop":
                            stringProp = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (arrayItemsNullable == null)
                throw new ArgumentNullException(nameof(arrayItemsNullable), "Property is required for class NullableClass.");

            if (objectItemsNullable == null)
                throw new ArgumentNullException(nameof(objectItemsNullable), "Property is required for class NullableClass.");

            return new NullableClass(arrayItemsNullable, objectItemsNullable, arrayAndItemsNullableProp, arrayNullableProp, booleanProp, dateProp, datetimeProp, integerProp, numberProp, objectAndItemsNullableProp, objectNullableProp, stringProp);
        }

        /// <summary>
        /// Serializes a <see cref="NullableClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NullableClass nullableClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, nullableClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NullableClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nullableClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, NullableClass nullableClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WritePropertyName("array_items_nullable");
            JsonSerializer.Serialize(writer, nullableClass.ArrayItemsNullable, jsonSerializerOptions);
            writer.WritePropertyName("object_items_nullable");
            JsonSerializer.Serialize(writer, nullableClass.ObjectItemsNullable, jsonSerializerOptions);
            writer.WritePropertyName("array_and_items_nullable_prop");
            JsonSerializer.Serialize(writer, nullableClass.ArrayAndItemsNullableProp, jsonSerializerOptions);
            writer.WritePropertyName("array_nullable_prop");
            JsonSerializer.Serialize(writer, nullableClass.ArrayNullableProp, jsonSerializerOptions);

            if (nullableClass.BooleanProp != null)
                writer.WriteBoolean("boolean_prop", nullableClass.BooleanProp.Value);
            else
                writer.WriteNull("boolean_prop");

            if (nullableClass.DateProp != null)
                writer.WriteString("date_prop", nullableClass.DateProp.Value.ToString(DatePropFormat));
            else
                writer.WriteNull("date_prop");

            if (nullableClass.DatetimeProp != null)
                writer.WriteString("datetime_prop", nullableClass.DatetimeProp.Value.ToString(DatetimePropFormat));
            else
                writer.WriteNull("datetime_prop");

            if (nullableClass.IntegerProp != null)
                writer.WriteNumber("integer_prop", nullableClass.IntegerProp.Value);
            else
                writer.WriteNull("integer_prop");

            if (nullableClass.NumberProp != null)
                writer.WriteNumber("number_prop", nullableClass.NumberProp.Value);
            else
                writer.WriteNull("number_prop");

            writer.WritePropertyName("object_and_items_nullable_prop");
            JsonSerializer.Serialize(writer, nullableClass.ObjectAndItemsNullableProp, jsonSerializerOptions);
            writer.WritePropertyName("object_nullable_prop");
            JsonSerializer.Serialize(writer, nullableClass.ObjectNullableProp, jsonSerializerOptions);
            writer.WriteString("string_prop", nullableClass.StringProp);
        }
    }
}
