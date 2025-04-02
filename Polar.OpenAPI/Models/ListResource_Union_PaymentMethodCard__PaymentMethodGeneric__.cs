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
    public partial class ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__ : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items>? Items { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items> Items { get; set; }
#endif
        /// <summary>The pagination property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Pagination? Pagination { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Pagination Pagination { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__"/> and sets the default values.
        /// </summary>
        public ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__ CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items>(global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagination", n => { Pagination = n.GetObjectValue<global::ApiSdk.Models.Pagination>(global::ApiSdk.Models.Pagination.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items>("items", Items);
            writer.WriteObjectValue<global::ApiSdk.Models.Pagination>("pagination", Pagination);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.PaymentMethodCard"/>, <see cref="global::ApiSdk.Models.PaymentMethodGeneric"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.PaymentMethodCard"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.PaymentMethodCard? PaymentMethodCard { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.PaymentMethodCard PaymentMethodCard { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.PaymentMethodGeneric"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.PaymentMethodGeneric? PaymentMethodGeneric { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.PaymentMethodGeneric PaymentMethodGeneric { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric__.ListResource_Union_PaymentMethodCard__PaymentMethodGeneric___items();
                result.PaymentMethodCard = new global::ApiSdk.Models.PaymentMethodCard();
                result.PaymentMethodGeneric = new global::ApiSdk.Models.PaymentMethodGeneric();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(PaymentMethodCard != null || PaymentMethodGeneric != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(PaymentMethodCard, PaymentMethodGeneric);
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
                writer.WriteObjectValue<global::ApiSdk.Models.PaymentMethodCard>(null, PaymentMethodCard, PaymentMethodGeneric);
            }
        }
    }
}
#pragma warning restore CS0618
