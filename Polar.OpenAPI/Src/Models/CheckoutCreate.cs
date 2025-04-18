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
    /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutPriceCreate"/>, <see cref="global::Polar.OpenAPI.Models.CheckoutProductCreate"/>, <see cref="global::Polar.OpenAPI.Models.CheckoutProductsCreate"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CheckoutCreate : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutPriceCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutPriceCreate? CheckoutPriceCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutPriceCreate CheckoutPriceCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutProductCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutProductCreate? CheckoutProductCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutProductCreate CheckoutProductCreate { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutProductsCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutProductsCreate? CheckoutProductsCreate { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutProductsCreate CheckoutProductsCreate { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.CheckoutCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var result = new global::Polar.OpenAPI.Models.CheckoutCreate();
            result.CheckoutPriceCreate = new global::Polar.OpenAPI.Models.CheckoutPriceCreate();
            result.CheckoutProductCreate = new global::Polar.OpenAPI.Models.CheckoutProductCreate();
            result.CheckoutProductsCreate = new global::Polar.OpenAPI.Models.CheckoutProductsCreate();
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(CheckoutPriceCreate != null || CheckoutProductCreate != null || CheckoutProductsCreate != null)
            {
                return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutPriceCreate, CheckoutProductCreate, CheckoutProductsCreate);
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
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutPriceCreate>(null, CheckoutPriceCreate, CheckoutProductCreate, CheckoutProductsCreate);
        }
    }
}
#pragma warning restore CS0618
