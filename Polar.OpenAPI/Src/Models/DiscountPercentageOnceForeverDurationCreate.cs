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
    /// Schema to create a percentage discount that is applied once or forever.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DiscountPercentageOnceForeverDurationCreate : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Discount percentage in basis points.A basis point is 1/100th of a percent.For example, to create a 25.5% discount, set this to 2550.</summary>
        public int? BasisPoints { get; set; }
        /// <summary>Code customers can use to apply the discount during checkout. Must be between 3 and 256 characters long and contain only alphanumeric characters.If not provided, the discount can only be applied via the API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code? Code { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code Code { get; set; }
#endif
        /// <summary>The duration property</summary>
        public global::Polar.OpenAPI.Models.DiscountDuration? Duration { get; set; }
        /// <summary>Optional timestamp after which the discount is no longer redeemable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at? EndsAt { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at EndsAt { get; set; }
#endif
        /// <summary>Optional maximum number of times the discount can be redeemed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions? MaxRedemptions { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions MaxRedemptions { get; set; }
#endif
        /// <summary>Key-value object allowing you to store additional information.The key must be a string with a maximum length of **40 characters**.The value must be either:* A string with a maximum length of **500 characters*** An integer* A booleanYou can store up to **50 key-value pairs**.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_metadata Metadata { get; set; }
#endif
        /// <summary>Name of the discount. Will be displayed to the customer when the discount is applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ID of the organization owning the discount. **Required unless you use an organization token.**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id? OrganizationId { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id OrganizationId { get; set; }
#endif
        /// <summary>The products property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products? Products { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products Products { get; set; }
#endif
        /// <summary>Optional timestamp after which the discount is redeemable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at? StartsAt { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at StartsAt { get; set; }
#endif
        /// <summary>Type of the discount.</summary>
        public global::Polar.OpenAPI.Models.DiscountType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate"/> and sets the default values.
        /// </summary>
        public DiscountPercentageOnceForeverDurationCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "basis_points", n => { BasisPoints = n.GetIntValue(); } },
                { "code", n => { Code = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code.CreateFromDiscriminatorValue); } },
                { "duration", n => { Duration = n.GetEnumValue<global::Polar.OpenAPI.Models.DiscountDuration>(); } },
                { "ends_at", n => { EndsAt = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at.CreateFromDiscriminatorValue); } },
                { "max_redemptions", n => { MaxRedemptions = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions.CreateFromDiscriminatorValue); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_metadata>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_metadata.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "organization_id", n => { OrganizationId = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id.CreateFromDiscriminatorValue); } },
                { "products", n => { Products = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products.CreateFromDiscriminatorValue); } },
                { "starts_at", n => { StartsAt = n.GetObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at>(global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Polar.OpenAPI.Models.DiscountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("basis_points", BasisPoints);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code>("code", Code);
            writer.WriteEnumValue<global::Polar.OpenAPI.Models.DiscountDuration>("duration", Duration);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at>("ends_at", EndsAt);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions>("max_redemptions", MaxRedemptions);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_metadata>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id>("organization_id", OrganizationId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products>("products", Products);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at>("starts_at", StartsAt);
            writer.WriteEnumValue<global::Polar.OpenAPI.Models.DiscountType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_codeMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DiscountPercentageOnceForeverDurationCreate_code : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_codeMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_codeMember1? DiscountPercentageOnceForeverDurationCreateCodeMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_codeMember1 DiscountPercentageOnceForeverDurationCreateCodeMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_code();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.DiscountPercentageOnceForeverDurationCreateCodeMember1 = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_codeMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DiscountPercentageOnceForeverDurationCreateCodeMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DiscountPercentageOnceForeverDurationCreateCodeMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_codeMember1>(null, DiscountPercentageOnceForeverDurationCreateCodeMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_ends_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DiscountPercentageOnceForeverDurationCreate_ends_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_ends_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_ends_atMember1? DiscountPercentageOnceForeverDurationCreateEndsAtMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_ends_atMember1 DiscountPercentageOnceForeverDurationCreateEndsAtMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_ends_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.DiscountPercentageOnceForeverDurationCreateEndsAtMember1 = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_ends_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DiscountPercentageOnceForeverDurationCreateEndsAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DiscountPercentageOnceForeverDurationCreateEndsAtMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_ends_atMember1>(null, DiscountPercentageOnceForeverDurationCreateEndsAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_max_redemptionsMember1"/>, <see cref="int"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DiscountPercentageOnceForeverDurationCreate_max_redemptions : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_max_redemptionsMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_max_redemptionsMember1? DiscountPercentageOnceForeverDurationCreateMaxRedemptionsMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_max_redemptionsMember1 DiscountPercentageOnceForeverDurationCreateMaxRedemptionsMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="int"/></summary>
            public int? Integer { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_max_redemptions();
                if(parseNode.GetIntValue() is int integerValue)
                {
                    result.Integer = integerValue;
                }
                else {
                    result.DiscountPercentageOnceForeverDurationCreateMaxRedemptionsMember1 = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_max_redemptionsMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DiscountPercentageOnceForeverDurationCreateMaxRedemptionsMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DiscountPercentageOnceForeverDurationCreateMaxRedemptionsMember1);
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
                if(Integer != null)
                {
                    writer.WriteIntValue(null, Integer);
                }
                else {
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_max_redemptionsMember1>(null, DiscountPercentageOnceForeverDurationCreateMaxRedemptionsMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_organization_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DiscountPercentageOnceForeverDurationCreate_organization_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_organization_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_organization_idMember1? DiscountPercentageOnceForeverDurationCreateOrganizationIdMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_organization_idMember1 DiscountPercentageOnceForeverDurationCreateOrganizationIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_organization_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.DiscountPercentageOnceForeverDurationCreateOrganizationIdMember1 = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_organization_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DiscountPercentageOnceForeverDurationCreateOrganizationIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DiscountPercentageOnceForeverDurationCreateOrganizationIdMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_organization_idMember1>(null, DiscountPercentageOnceForeverDurationCreateOrganizationIdMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_productsMember1"/>, List&lt;string&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DiscountPercentageOnceForeverDurationCreate_products : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_productsMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_productsMember1? DiscountPercentageOnceForeverDurationCreateProductsMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_productsMember1 DiscountPercentageOnceForeverDurationCreateProductsMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_products();
                if(parseNode.GetCollectionOfPrimitiveValues<string>()?.AsList() is List<string> stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.DiscountPercentageOnceForeverDurationCreateProductsMember1 = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_productsMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DiscountPercentageOnceForeverDurationCreateProductsMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DiscountPercentageOnceForeverDurationCreateProductsMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_productsMember1>(null, DiscountPercentageOnceForeverDurationCreateProductsMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_starts_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DiscountPercentageOnceForeverDurationCreate_starts_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_starts_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_starts_atMember1? DiscountPercentageOnceForeverDurationCreateStartsAtMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_starts_atMember1 DiscountPercentageOnceForeverDurationCreateStartsAtMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate.DiscountPercentageOnceForeverDurationCreate_starts_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.DiscountPercentageOnceForeverDurationCreateStartsAtMember1 = new global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_starts_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DiscountPercentageOnceForeverDurationCreateStartsAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DiscountPercentageOnceForeverDurationCreateStartsAtMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.DiscountPercentageOnceForeverDurationCreate_starts_atMember1>(null, DiscountPercentageOnceForeverDurationCreateStartsAtMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
