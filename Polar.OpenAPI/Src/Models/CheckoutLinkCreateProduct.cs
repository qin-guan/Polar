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
    /// Schema to create a new checkout link from a a single product.**Deprecated**: Use `CheckoutLinkCreateProducts` instead.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CheckoutLinkCreateProduct : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to allow the customer to apply discount codes. If you apply a discount through `discount_id`, it&apos;ll still be applied, but the customer won&apos;t be able to change it.</summary>
        public bool? AllowDiscountCodes { get; set; }
        /// <summary>ID of the discount to apply to the checkout. If the discount is not applicable anymore when opening the checkout link, it&apos;ll be ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id? DiscountId { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id DiscountId { get; set; }
#endif
        /// <summary>Optional label to distinguish links internally</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label? Label { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label Label { get; set; }
#endif
        /// <summary>Key-value object allowing you to store additional information.The key must be a string with a maximum length of **40 characters**.The value must be either:* A string with a maximum length of **500 characters*** An integer* A booleanYou can store up to **50 key-value pairs**.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_metadata Metadata { get; set; }
#endif
        /// <summary>Payment processor to use. Currently only Stripe is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentProcessor { get; set; }
#nullable restore
#else
        public string PaymentProcessor { get; set; }
#endif
        /// <summary>The product_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductId { get; set; }
#nullable restore
#else
        public string ProductId { get; set; }
#endif
        /// <summary>URL where the customer will be redirected after a successful payment.You can add the `checkout_id={CHECKOUT_ID}` query parameter to retrieve the checkout session id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url? SuccessUrl { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url SuccessUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct"/> and sets the default values.
        /// </summary>
        public CheckoutLinkCreateProduct()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_discount_codes", n => { AllowDiscountCodes = n.GetBoolValue(); } },
                { "discount_id", n => { DiscountId = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id>(global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id.CreateFromDiscriminatorValue); } },
                { "label", n => { Label = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label>(global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label.CreateFromDiscriminatorValue); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_metadata>(global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_metadata.CreateFromDiscriminatorValue); } },
                { "payment_processor", n => { PaymentProcessor = n.GetStringValue(); } },
                { "product_id", n => { ProductId = n.GetStringValue(); } },
                { "success_url", n => { SuccessUrl = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url>(global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_discount_codes", AllowDiscountCodes);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id>("discount_id", DiscountId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label>("label", Label);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_metadata>("metadata", Metadata);
            writer.WriteStringValue("payment_processor", PaymentProcessor);
            writer.WriteStringValue("product_id", ProductId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url>("success_url", SuccessUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_discount_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkCreateProduct_discount_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_discount_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_discount_idMember1? CheckoutLinkCreateProductDiscountIdMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_discount_idMember1 CheckoutLinkCreateProductDiscountIdMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_discount_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkCreateProductDiscountIdMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_discount_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkCreateProductDiscountIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkCreateProductDiscountIdMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_discount_idMember1>(null, CheckoutLinkCreateProductDiscountIdMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_labelMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkCreateProduct_label : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_labelMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_labelMember1? CheckoutLinkCreateProductLabelMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_labelMember1 CheckoutLinkCreateProductLabelMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_label();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkCreateProductLabelMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_labelMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkCreateProductLabelMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkCreateProductLabelMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_labelMember1>(null, CheckoutLinkCreateProductLabelMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_success_urlMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkCreateProduct_success_url : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_success_urlMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_success_urlMember1? CheckoutLinkCreateProductSuccessUrlMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_success_urlMember1 CheckoutLinkCreateProductSuccessUrlMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct.CheckoutLinkCreateProduct_success_url();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkCreateProductSuccessUrlMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_success_urlMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkCreateProductSuccessUrlMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkCreateProductSuccessUrlMember1);
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
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkCreateProduct_success_urlMember1>(null, CheckoutLinkCreateProductSuccessUrlMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
