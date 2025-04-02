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
    public partial class CustomerSubscriptionCancel : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Cancel an active subscription once the current period ends.Or uncancel a subscription currently set to be revoked at period end.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end? CancelAtPeriodEnd { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end CancelAtPeriodEnd { get; set; }
#endif
        /// <summary>Customer feedback and why they decided to cancel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment? CancellationComment { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment CancellationComment { get; set; }
#endif
        /// <summary>Customers reason for cancellation.* `too_expensive`: Too expensive for the customer.* `missing_features`: Customer is missing certain features.* `switched_service`: Customer switched to another service.* `unused`: Customer is not using it enough.* `customer_service`: Customer is not satisfied with the customer service.* `low_quality`: Customer is unhappy with the quality.* `too_complex`: Customer considers the service too complicated.* `other`: Other reason(s).</summary>
        public global::ApiSdk.Models.CustomerCancellationReason? CancellationReason { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel"/> and sets the default values.
        /// </summary>
        public CustomerSubscriptionCancel()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.CustomerSubscriptionCancel CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CustomerSubscriptionCancel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cancel_at_period_end", n => { CancelAtPeriodEnd = n.GetObjectValue<global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end>(global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end.CreateFromDiscriminatorValue); } },
                { "cancellation_comment", n => { CancellationComment = n.GetObjectValue<global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment>(global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment.CreateFromDiscriminatorValue); } },
                { "cancellation_reason", n => { CancellationReason = n.GetEnumValue<global::ApiSdk.Models.CustomerCancellationReason>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end>("cancel_at_period_end", CancelAtPeriodEnd);
            writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment>("cancellation_comment", CancellationComment);
            writer.WriteEnumValue<global::ApiSdk.Models.CustomerCancellationReason>("cancellation_reason", CancellationReason);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="bool"/>, <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel_cancel_at_period_endMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerSubscriptionCancel_cancel_at_period_end : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="bool"/></summary>
            public bool? Boolean { get; set; }
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel_cancel_at_period_endMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerSubscriptionCancel_cancel_at_period_endMember1? CustomerSubscriptionCancelCancelAtPeriodEndMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerSubscriptionCancel_cancel_at_period_endMember1 CustomerSubscriptionCancelCancelAtPeriodEndMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancel_at_period_end();
                if(parseNode.GetBoolValue() is bool booleanValue)
                {
                    result.Boolean = booleanValue;
                }
                else {
                    result.CustomerSubscriptionCancelCancelAtPeriodEndMember1 = new global::ApiSdk.Models.CustomerSubscriptionCancel_cancel_at_period_endMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerSubscriptionCancelCancelAtPeriodEndMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerSubscriptionCancelCancelAtPeriodEndMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionCancel_cancel_at_period_endMember1>(null, CustomerSubscriptionCancelCancelAtPeriodEndMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel_cancellation_commentMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CustomerSubscriptionCancel_cancellation_comment : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel_cancellation_commentMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.CustomerSubscriptionCancel_cancellation_commentMember1? CustomerSubscriptionCancelCancellationCommentMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.CustomerSubscriptionCancel_cancellation_commentMember1 CustomerSubscriptionCancelCancellationCommentMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.CustomerSubscriptionCancel.CustomerSubscriptionCancel_cancellation_comment();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.CustomerSubscriptionCancelCancellationCommentMember1 = new global::ApiSdk.Models.CustomerSubscriptionCancel_cancellation_commentMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomerSubscriptionCancelCancellationCommentMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(CustomerSubscriptionCancelCancellationCommentMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.CustomerSubscriptionCancel_cancellation_commentMember1>(null, CustomerSubscriptionCancelCancellationCommentMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
