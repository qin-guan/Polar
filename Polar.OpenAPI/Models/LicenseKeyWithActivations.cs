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
    public partial class LicenseKeyWithActivations : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.LicenseKeyActivationBase>? Activations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.LicenseKeyActivationBase> Activations { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The benefit ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BenefitId { get; set; }
#nullable restore
#else
        public string BenefitId { get; set; }
#endif
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LicenseKeyCustomer? Customer { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LicenseKeyCustomer Customer { get; set; }
#endif
        /// <summary>The customer_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId { get; set; }
#nullable restore
#else
        public string CustomerId { get; set; }
#endif
        /// <summary>The display_key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayKey { get; set; }
#nullable restore
#else
        public string DisplayKey { get; set; }
#endif
        /// <summary>The expires_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at? ExpiresAt { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at ExpiresAt { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The last_validated_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at? LastValidatedAt { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at LastValidatedAt { get; set; }
#endif
        /// <summary>The limit_activations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations? LimitActivations { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations LimitActivations { get; set; }
#endif
        /// <summary>The limit_usage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage? LimitUsage { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage LimitUsage { get; set; }
#endif
        /// <summary>The organization_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId { get; set; }
#nullable restore
#else
        public string OrganizationId { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.LicenseKeyStatus? Status { get; set; }
        /// <summary>The usage property</summary>
        public int? Usage { get; set; }
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.LicenseKeyUser? User { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.LicenseKeyUser User { get; set; }
#endif
        /// <summary>The user_id property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>The validations property</summary>
        public int? Validations { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.LicenseKeyWithActivations"/> and sets the default values.
        /// </summary>
        public LicenseKeyWithActivations()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.LicenseKeyWithActivations"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.LicenseKeyWithActivations CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.LicenseKeyWithActivations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activations", n => { Activations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.LicenseKeyActivationBase>(global::ApiSdk.Models.LicenseKeyActivationBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "benefit_id", n => { BenefitId = n.GetStringValue(); } },
                { "customer", n => { Customer = n.GetObjectValue<global::ApiSdk.Models.LicenseKeyCustomer>(global::ApiSdk.Models.LicenseKeyCustomer.CreateFromDiscriminatorValue); } },
                { "customer_id", n => { CustomerId = n.GetStringValue(); } },
                { "display_key", n => { DisplayKey = n.GetStringValue(); } },
                { "expires_at", n => { ExpiresAt = n.GetObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at>(global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "last_validated_at", n => { LastValidatedAt = n.GetObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at>(global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at.CreateFromDiscriminatorValue); } },
                { "limit_activations", n => { LimitActivations = n.GetObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations>(global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations.CreateFromDiscriminatorValue); } },
                { "limit_usage", n => { LimitUsage = n.GetObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage>(global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage.CreateFromDiscriminatorValue); } },
                { "organization_id", n => { OrganizationId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.LicenseKeyStatus>(); } },
                { "usage", n => { Usage = n.GetIntValue(); } },
                { "user", n => { User = n.GetObjectValue<global::ApiSdk.Models.LicenseKeyUser>(global::ApiSdk.Models.LicenseKeyUser.CreateFromDiscriminatorValue); } },
                { "user_id", n => { UserId = n.GetStringValue(); } },
                { "validations", n => { Validations = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.LicenseKeyActivationBase>("activations", Activations);
            writer.WriteStringValue("benefit_id", BenefitId);
            writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyCustomer>("customer", Customer);
            writer.WriteStringValue("customer_id", CustomerId);
            writer.WriteStringValue("display_key", DisplayKey);
            writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at>("expires_at", ExpiresAt);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("key", Key);
            writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at>("last_validated_at", LastValidatedAt);
            writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations>("limit_activations", LimitActivations);
            writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage>("limit_usage", LimitUsage);
            writer.WriteStringValue("organization_id", OrganizationId);
            writer.WriteEnumValue<global::ApiSdk.Models.LicenseKeyStatus>("status", Status);
            writer.WriteIntValue("usage", Usage);
            writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyUser>("user", User);
            writer.WriteStringValue("user_id", UserId);
            writer.WriteIntValue("validations", Validations);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_expires_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LicenseKeyWithActivations_expires_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_expires_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.LicenseKeyWithActivations_expires_atMember1? LicenseKeyWithActivationsExpiresAtMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.LicenseKeyWithActivations_expires_atMember1 LicenseKeyWithActivationsExpiresAtMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_expires_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.LicenseKeyWithActivationsExpiresAtMember1 = new global::ApiSdk.Models.LicenseKeyWithActivations_expires_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LicenseKeyWithActivationsExpiresAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(LicenseKeyWithActivationsExpiresAtMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations_expires_atMember1>(null, LicenseKeyWithActivationsExpiresAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_last_validated_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LicenseKeyWithActivations_last_validated_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_last_validated_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.LicenseKeyWithActivations_last_validated_atMember1? LicenseKeyWithActivationsLastValidatedAtMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.LicenseKeyWithActivations_last_validated_atMember1 LicenseKeyWithActivationsLastValidatedAtMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_last_validated_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.LicenseKeyWithActivationsLastValidatedAtMember1 = new global::ApiSdk.Models.LicenseKeyWithActivations_last_validated_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LicenseKeyWithActivationsLastValidatedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(LicenseKeyWithActivationsLastValidatedAtMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations_last_validated_atMember1>(null, LicenseKeyWithActivationsLastValidatedAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_limit_activationsMember1"/>, <see cref="int"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LicenseKeyWithActivations_limit_activations : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="int"/></summary>
            public int? Integer { get; set; }
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_limit_activationsMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.LicenseKeyWithActivations_limit_activationsMember1? LicenseKeyWithActivationsLimitActivationsMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.LicenseKeyWithActivations_limit_activationsMember1 LicenseKeyWithActivationsLimitActivationsMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_activations();
                if(parseNode.GetIntValue() is int integerValue)
                {
                    result.Integer = integerValue;
                }
                else {
                    result.LicenseKeyWithActivationsLimitActivationsMember1 = new global::ApiSdk.Models.LicenseKeyWithActivations_limit_activationsMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LicenseKeyWithActivationsLimitActivationsMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(LicenseKeyWithActivationsLimitActivationsMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations_limit_activationsMember1>(null, LicenseKeyWithActivationsLimitActivationsMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_limit_usageMember1"/>, <see cref="int"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LicenseKeyWithActivations_limit_usage : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="int"/></summary>
            public int? Integer { get; set; }
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.LicenseKeyWithActivations_limit_usageMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.LicenseKeyWithActivations_limit_usageMember1? LicenseKeyWithActivationsLimitUsageMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.LicenseKeyWithActivations_limit_usageMember1 LicenseKeyWithActivationsLimitUsageMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.LicenseKeyWithActivations.LicenseKeyWithActivations_limit_usage();
                if(parseNode.GetIntValue() is int integerValue)
                {
                    result.Integer = integerValue;
                }
                else {
                    result.LicenseKeyWithActivationsLimitUsageMember1 = new global::ApiSdk.Models.LicenseKeyWithActivations_limit_usageMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LicenseKeyWithActivationsLimitUsageMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(LicenseKeyWithActivationsLimitUsageMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.LicenseKeyWithActivations_limit_usageMember1>(null, LicenseKeyWithActivationsLimitUsageMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
