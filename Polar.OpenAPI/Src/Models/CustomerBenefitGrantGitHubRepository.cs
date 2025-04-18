// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Polar.OpenAPI.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CustomerBenefitGrantGitHubRepository : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The benefit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.BenefitGitHubRepositorySubscriber? Benefit { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.BenefitGitHubRepositorySubscriber Benefit { get; set; }
#endif
        /// <summary>The benefit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BenefitId { get; set; }
#nullable restore
#else
        public string BenefitId { get; set; }
#endif
        /// <summary>Creation timestamp of the object.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CustomerPortalCustomer? Customer { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CustomerPortalCustomer Customer { get; set; }
#endif
        /// <summary>The customer_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId { get; set; }
#nullable restore
#else
        public string CustomerId { get; set; }
#endif
        /// <summary>The granted_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at? GrantedAt { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at GrantedAt { get; set; }
#endif
        /// <summary>The ID of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The is_granted property</summary>
        public bool? IsGranted { get; set; }
        /// <summary>The is_revoked property</summary>
        public bool? IsRevoked { get; set; }
        /// <summary>Last modification timestamp of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at? ModifiedAt { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at ModifiedAt { get; set; }
#endif
        /// <summary>The order_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id? OrderId { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id OrderId { get; set; }
#endif
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.BenefitGrantGitHubRepositoryProperties? Properties { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.BenefitGrantGitHubRepositoryProperties Properties { get; set; }
#endif
        /// <summary>The revoked_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at? RevokedAt { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at RevokedAt { get; set; }
#endif
        /// <summary>The subscription_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id? SubscriptionId { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id SubscriptionId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository"/> and sets the default values.
        /// </summary>
        public CustomerBenefitGrantGitHubRepository()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "benefit", n => { Benefit = n.GetObjectValue<global::Polar.OpenAPI.Models.BenefitGitHubRepositorySubscriber>(global::Polar.OpenAPI.Models.BenefitGitHubRepositorySubscriber.CreateFromDiscriminatorValue); } },
                { "benefit_id", n => { BenefitId = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "customer", n => { Customer = n.GetObjectValue<global::Polar.OpenAPI.Models.CustomerPortalCustomer>(global::Polar.OpenAPI.Models.CustomerPortalCustomer.CreateFromDiscriminatorValue); } },
                { "customer_id", n => { CustomerId = n.GetStringValue(); } },
                { "granted_at", n => { GrantedAt = n.GetObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at>(global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "is_granted", n => { IsGranted = n.GetBoolValue(); } },
                { "is_revoked", n => { IsRevoked = n.GetBoolValue(); } },
                { "modified_at", n => { ModifiedAt = n.GetObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at>(global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at.CreateFromDiscriminatorValue); } },
                { "order_id", n => { OrderId = n.GetObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id>(global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id.CreateFromDiscriminatorValue); } },
                { "properties", n => { Properties = n.GetObjectValue<global::Polar.OpenAPI.Models.BenefitGrantGitHubRepositoryProperties>(global::Polar.OpenAPI.Models.BenefitGrantGitHubRepositoryProperties.CreateFromDiscriminatorValue); } },
                { "revoked_at", n => { RevokedAt = n.GetObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at>(global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at.CreateFromDiscriminatorValue); } },
                { "subscription_id", n => { SubscriptionId = n.GetObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id>(global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.BenefitGitHubRepositorySubscriber>("benefit", Benefit);
            writer.WriteStringValue("benefit_id", BenefitId);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerPortalCustomer>("customer", Customer);
            writer.WriteStringValue("customer_id", CustomerId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at>("granted_at", GrantedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("is_granted", IsGranted);
            writer.WriteBoolValue("is_revoked", IsRevoked);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at>("modified_at", ModifiedAt);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id>("order_id", OrderId);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.BenefitGrantGitHubRepositoryProperties>("properties", Properties);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at>("revoked_at", RevokedAt);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id>("subscription_id", SubscriptionId);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_granted_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerBenefitGrantGitHubRepository_granted_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_granted_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_granted_atMember1? CustomerBenefitGrantGitHubRepositoryGrantedAtMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_granted_atMember1 CustomerBenefitGrantGitHubRepositoryGrantedAtMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_granted_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.CustomerBenefitGrantGitHubRepositoryGrantedAtMember1 = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_granted_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerBenefitGrantGitHubRepositoryGrantedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerBenefitGrantGitHubRepositoryGrantedAtMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_granted_atMember1>(null, CustomerBenefitGrantGitHubRepositoryGrantedAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_modified_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerBenefitGrantGitHubRepository_modified_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_modified_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_modified_atMember1? CustomerBenefitGrantGitHubRepositoryModifiedAtMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_modified_atMember1 CustomerBenefitGrantGitHubRepositoryModifiedAtMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_modified_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.CustomerBenefitGrantGitHubRepositoryModifiedAtMember1 = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_modified_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerBenefitGrantGitHubRepositoryModifiedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerBenefitGrantGitHubRepositoryModifiedAtMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_modified_atMember1>(null, CustomerBenefitGrantGitHubRepositoryModifiedAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_order_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerBenefitGrantGitHubRepository_order_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_order_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_order_idMember1? CustomerBenefitGrantGitHubRepositoryOrderIdMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_order_idMember1 CustomerBenefitGrantGitHubRepositoryOrderIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_order_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerBenefitGrantGitHubRepositoryOrderIdMember1 = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_order_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerBenefitGrantGitHubRepositoryOrderIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerBenefitGrantGitHubRepositoryOrderIdMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_order_idMember1>(null, CustomerBenefitGrantGitHubRepositoryOrderIdMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="DateTimeOffset"/>, <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_revoked_atMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerBenefitGrantGitHubRepository_revoked_at : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_revoked_atMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_revoked_atMember1? CustomerBenefitGrantGitHubRepositoryRevokedAtMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_revoked_atMember1 CustomerBenefitGrantGitHubRepositoryRevokedAtMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="DateTimeOffset"/></summary>
            public DateTimeOffset? DateTimeOffset { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_revoked_at();
                if(parseNode.GetDateTimeOffsetValue() is DateTimeOffset dateTimeOffsetValue)
                {
                    result.DateTimeOffset = dateTimeOffsetValue;
                }
                else {
                    result.CustomerBenefitGrantGitHubRepositoryRevokedAtMember1 = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_revoked_atMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerBenefitGrantGitHubRepositoryRevokedAtMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerBenefitGrantGitHubRepositoryRevokedAtMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_revoked_atMember1>(null, CustomerBenefitGrantGitHubRepositoryRevokedAtMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_subscription_idMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerBenefitGrantGitHubRepository_subscription_id : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_subscription_idMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_subscription_idMember1? CustomerBenefitGrantGitHubRepositorySubscriptionIdMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_subscription_idMember1 CustomerBenefitGrantGitHubRepositorySubscriptionIdMember1 { get; set; }
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
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository.CustomerBenefitGrantGitHubRepository_subscription_id();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerBenefitGrantGitHubRepositorySubscriptionIdMember1 = new global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_subscription_idMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerBenefitGrantGitHubRepositorySubscriptionIdMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerBenefitGrantGitHubRepositorySubscriptionIdMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.CustomerBenefitGrantGitHubRepository_subscription_idMember1>(null, CustomerBenefitGrantGitHubRepositorySubscriptionIdMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
