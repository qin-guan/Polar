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
    /// Schema to update an existing checkout link.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CheckoutLinkUpdate : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to allow the customer to apply discount codes. If you apply a discount through `discount_id`, it&apos;ll still be applied, but the customer won&apos;t be able to change it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes? AllowDiscountCodes { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes AllowDiscountCodes { get; set; }
#endif
        /// <summary>ID of the discount to apply to the checkout. If the discount is not applicable anymore when opening the checkout link, it&apos;ll be ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id? DiscountId { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id DiscountId { get; set; }
#endif
        /// <summary>The label property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label? Label { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label Label { get; set; }
#endif
        /// <summary>Key-value object allowing you to store additional information.The key must be a string with a maximum length of **40 characters**.The value must be either:* A string with a maximum length of **500 characters*** An integer* A booleanYou can store up to **50 key-value pairs**.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_metadata Metadata { get; set; }
#endif
        /// <summary>List of products that will be available to select at checkout.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products? Products { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products Products { get; set; }
#endif
        /// <summary>URL where the customer will be redirected after a successful payment.You can add the `checkout_id={CHECKOUT_ID}` query parameter to retrieve the checkout session id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url? SuccessUrl { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url SuccessUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate"/> and sets the default values.
        /// </summary>
        public CheckoutLinkUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.CheckoutLinkUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Polar.OpenAPI.Models.CheckoutLinkUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_discount_codes", n => { AllowDiscountCodes = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes>(global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes.CreateFromDiscriminatorValue); } },
                { "discount_id", n => { DiscountId = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id>(global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id.CreateFromDiscriminatorValue); } },
                { "label", n => { Label = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label>(global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label.CreateFromDiscriminatorValue); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_metadata>(global::Polar.OpenAPI.Models.CheckoutLinkUpdate_metadata.CreateFromDiscriminatorValue); } },
                { "products", n => { Products = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products>(global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products.CreateFromDiscriminatorValue); } },
                { "success_url", n => { SuccessUrl = n.GetObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url>(global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes>("allow_discount_codes", AllowDiscountCodes);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id>("discount_id", DiscountId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label>("label", Label);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_metadata>("metadata", Metadata);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products>("products", Products);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url>("success_url", SuccessUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="bool"/>, <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_allow_discount_codesMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkUpdate_allow_discount_codes : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="bool"/></summary>
            public bool? Boolean { get; set; }
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_allow_discount_codesMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_allow_discount_codesMember1? CheckoutLinkUpdateAllowDiscountCodesMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_allow_discount_codesMember1 CheckoutLinkUpdateAllowDiscountCodesMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_allow_discount_codes();
                if(parseNode.GetBoolValue() is bool booleanValue)
                {
                    result.Boolean = booleanValue;
                }
                else {
                    result.CheckoutLinkUpdateAllowDiscountCodesMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate_allow_discount_codesMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkUpdateAllowDiscountCodesMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkUpdateAllowDiscountCodesMember1);
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
                if(Boolean != null)
                {
                    writer.WriteBoolValue(null, Boolean);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_allow_discount_codesMember1>(null, CheckoutLinkUpdateAllowDiscountCodesMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_discount_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkUpdate_discount_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_discount_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_discount_idMember1? CheckoutLinkUpdateDiscountIdMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_discount_idMember1 CheckoutLinkUpdateDiscountIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_discount_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkUpdateDiscountIdMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate_discount_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkUpdateDiscountIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkUpdateDiscountIdMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_discount_idMember1>(null, CheckoutLinkUpdateDiscountIdMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_labelMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkUpdate_label : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_labelMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_labelMember1? CheckoutLinkUpdateLabelMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_labelMember1 CheckoutLinkUpdateLabelMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_label();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkUpdateLabelMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate_labelMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkUpdateLabelMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkUpdateLabelMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_labelMember1>(null, CheckoutLinkUpdateLabelMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_productsMember1"/>, List&lt;string&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkUpdate_products : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_productsMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_productsMember1? CheckoutLinkUpdateProductsMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_productsMember1 CheckoutLinkUpdateProductsMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;string&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<string>? String { get; set; }
#nullable restore
#else
            public List<string> String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_products();
                if(parseNode.GetCollectionOfPrimitiveValues<string>()?.AsList() is List<string> stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkUpdateProductsMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate_productsMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkUpdateProductsMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkUpdateProductsMember1);
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
                    writer.WriteCollectionOfPrimitiveValues<string>(null, String);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_productsMember1>(null, CheckoutLinkUpdateProductsMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_success_urlMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckoutLinkUpdate_success_url : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate_success_urlMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_success_urlMember1? CheckoutLinkUpdateSuccessUrlMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CheckoutLinkUpdate_success_urlMember1 CheckoutLinkUpdateSuccessUrlMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate.CheckoutLinkUpdate_success_url();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CheckoutLinkUpdateSuccessUrlMember1 = new global::Polar.OpenAPI.Models.CheckoutLinkUpdate_success_urlMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckoutLinkUpdateSuccessUrlMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CheckoutLinkUpdateSuccessUrlMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CheckoutLinkUpdate_success_urlMember1>(null, CheckoutLinkUpdateSuccessUrlMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
