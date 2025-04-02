// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CustomerSubscriptionProduct : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of benefits granted by the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BenefitBase>? Benefits { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BenefitBase> Benefits { get; set; }
#endif
        /// <summary>Creation timestamp of the object.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The description of the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description? Description { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description Description { get; set; }
#endif
        /// <summary>The ID of the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Whether the product is archived and no longer available.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Whether the product is a subscription.</summary>
        public bool? IsRecurring { get; set; }
        /// <summary>List of medias associated to the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ProductMediaFileRead>? Medias { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ProductMediaFileRead> Medias { get; set; }
#endif
        /// <summary>Last modification timestamp of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at? ModifiedAt { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at ModifiedAt { get; set; }
#endif
        /// <summary>The name of the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The organization property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Organization? Organization { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Organization Organization { get; set; }
#endif
        /// <summary>The ID of the organization owning the product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId { get; set; }
#nullable restore
#else
        public string OrganizationId { get; set; }
#endif
        /// <summary>List of prices for this product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices>? Prices { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices> Prices { get; set; }
#endif
        /// <summary>The recurring interval of the product. If `None`, the product is a one-time purchase.</summary>
        public global::ApiSdk.Models.SubscriptionRecurringInterval? RecurringInterval { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct"/> and sets the default values.
        /// </summary>
        public CustomerSubscriptionProduct()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CustomerSubscriptionProduct CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CustomerSubscriptionProduct();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "benefits", n => { Benefits = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BenefitBase>(global::ApiSdk.Models.BenefitBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetObjectValue<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description>(global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "is_archived", n => { IsArchived = n.GetBoolValue(); } },
                { "is_recurring", n => { IsRecurring = n.GetBoolValue(); } },
                { "medias", n => { Medias = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ProductMediaFileRead>(global::ApiSdk.Models.ProductMediaFileRead.CreateFromDiscriminatorValue)?.AsList(); } },
                { "modified_at", n => { ModifiedAt = n.GetObjectValue<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at>(global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "organization", n => { Organization = n.GetObjectValue<global::ApiSdk.Models.Organization>(global::ApiSdk.Models.Organization.CreateFromDiscriminatorValue); } },
                { "organization_id", n => { OrganizationId = n.GetStringValue(); } },
                { "prices", n => { Prices = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices>(global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices.CreateFromDiscriminatorValue)?.AsList(); } },
                { "recurring_interval", n => { RecurringInterval = n.GetEnumValue<global::ApiSdk.Models.SubscriptionRecurringInterval>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BenefitBase>("benefits", Benefits);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description>("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("is_archived", IsArchived);
            writer.WriteBoolValue("is_recurring", IsRecurring);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ProductMediaFileRead>("medias", Medias);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at>("modified_at", ModifiedAt);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.Organization>("organization", Organization);
            writer.WriteStringValue("organization_id", OrganizationId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices>("prices", Prices);
            writer.WriteEnumValue<global::ApiSdk.Models.SubscriptionRecurringInterval>("recurring_interval", RecurringInterval);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct_descriptionMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerSubscriptionProduct_description : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct_descriptionMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerSubscriptionProduct_descriptionMember1? CustomerSubscriptionProductDescriptionMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerSubscriptionProduct_descriptionMember1 CustomerSubscriptionProductDescriptionMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_description();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerSubscriptionProductDescriptionMember1 = new global::ApiSdk.Models.CustomerSubscriptionProduct_descriptionMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerSubscriptionProductDescriptionMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerSubscriptionProductDescriptionMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionProduct_descriptionMember1>(null, CustomerSubscriptionProductDescriptionMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct_modified_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerSubscriptionProduct_modified_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct_modified_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerSubscriptionProduct_modified_atMember1? CustomerSubscriptionProductModifiedAtMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerSubscriptionProduct_modified_atMember1 CustomerSubscriptionProductModifiedAtMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_modified_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.CustomerSubscriptionProductModifiedAtMember1 = new global::ApiSdk.Models.CustomerSubscriptionProduct_modified_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerSubscriptionProductModifiedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerSubscriptionProductModifiedAtMember1);
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
                if(DateTimeOffset != null)
                {
                    writer.WriteDateTimeOffsetValue(null, DateTimeOffset);
                }
                else {
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionProduct_modified_atMember1>(null, CustomerSubscriptionProductModifiedAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.LegacyRecurringProductPrice"/>, <see cref="global::ApiSdk.Models.ProductPrice"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerSubscriptionProduct_prices : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.LegacyRecurringProductPrice"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.LegacyRecurringProductPrice? LegacyRecurringProductPrice { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.LegacyRecurringProductPrice LegacyRecurringProductPrice { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.ProductPrice"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.ProductPrice? ProductPrice { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.ProductPrice ProductPrice { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("amount_type")?.GetStringValue();
                var result = new global::ApiSdk.Models.CustomerSubscriptionProduct.CustomerSubscriptionProduct_prices();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LegacyRecurringProductPrice = new global::ApiSdk.Models.LegacyRecurringProductPrice();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProductPrice = new global::ApiSdk.Models.ProductPrice();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LegacyRecurringProductPrice != null)
                {
                    return LegacyRecurringProductPrice.GetFieldDeserializers();
                }
                else if(ProductPrice != null)
                {
                    return ProductPrice.GetFieldDeserializers();
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
                if(LegacyRecurringProductPrice != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.LegacyRecurringProductPrice>(null, LegacyRecurringProductPrice);
                }
                else if(ProductPrice != null)
                {
                    writer.WriteObjectValue<global::ApiSdk.Models.ProductPrice>(null, ProductPrice);
                }
            }
        }
    }
}
#pragma warning restore CS0618
