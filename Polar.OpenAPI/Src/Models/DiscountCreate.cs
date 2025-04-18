// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Polar.OpenAPI.Models
{
    /// <summary>
    /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.DiscountFixedOnceForeverDurationCreate"/>, <see cref="global::Polar.OpenAPI.Models.DiscountFixedRepeatDurationCreate"/>, <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate"/>, <see cref="global::Polar.OpenAPI.Models.DiscountPercentageRepeatDurationCreate"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DiscountCreate : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountFixedOnceForeverDurationCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountFixedOnceForeverDurationCreate? DiscountFixedOnceForeverDurationCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountFixedOnceForeverDurationCreate DiscountFixedOnceForeverDurationCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountFixedRepeatDurationCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountFixedRepeatDurationCreate? DiscountFixedRepeatDurationCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountFixedRepeatDurationCreate DiscountFixedRepeatDurationCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate? DiscountPercentageOnceForeverDurationCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate DiscountPercentageOnceForeverDurationCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageRepeatDurationCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageRepeatDurationCreate? DiscountPercentageRepeatDurationCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageRepeatDurationCreate DiscountPercentageRepeatDurationCreate { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.DiscountCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
            var result = new global::Polar.OpenAPI.Models.DiscountCreate();
            if("DiscountFixedOnceForeverDurationCreate".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.DiscountFixedOnceForeverDurationCreate = new global::Polar.OpenAPI.Models.DiscountFixedOnceForeverDurationCreate();
            }
            else if("DiscountFixedRepeatDurationCreate".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.DiscountFixedRepeatDurationCreate = new global::Polar.OpenAPI.Models.DiscountFixedRepeatDurationCreate();
            }
            else if("DiscountPercentageOnceForeverDurationCreate".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.DiscountPercentageOnceForeverDurationCreate = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate();
            }
            else if("DiscountPercentageRepeatDurationCreate".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.DiscountPercentageRepeatDurationCreate = new global::Polar.OpenAPI.Models.DiscountPercentageRepeatDurationCreate();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(DiscountFixedOnceForeverDurationCreate != null)
            {
                return DiscountFixedOnceForeverDurationCreate.GetFieldDeserializers();
            }
            else if(DiscountFixedRepeatDurationCreate != null)
            {
                return DiscountFixedRepeatDurationCreate.GetFieldDeserializers();
            }
            else if(DiscountPercentageOnceForeverDurationCreate != null)
            {
                return DiscountPercentageOnceForeverDurationCreate.GetFieldDeserializers();
            }
            else if(DiscountPercentageRepeatDurationCreate != null)
            {
                return DiscountPercentageRepeatDurationCreate.GetFieldDeserializers();
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            if(DiscountFixedOnceForeverDurationCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountFixedOnceForeverDurationCreate>(null, DiscountFixedOnceForeverDurationCreate);
            }
            else if(DiscountFixedRepeatDurationCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountFixedRepeatDurationCreate>(null, DiscountFixedRepeatDurationCreate);
            }
            else if(DiscountPercentageOnceForeverDurationCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate>(null, DiscountPercentageOnceForeverDurationCreate);
            }
            else if(DiscountPercentageRepeatDurationCreate != null)
            {
                writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageRepeatDurationCreate>(null, DiscountPercentageRepeatDurationCreate);
            }
        }
    }
}
#pragma warning restore CS0618
