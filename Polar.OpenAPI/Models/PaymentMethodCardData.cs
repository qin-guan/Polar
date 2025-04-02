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
    public partial class PaymentMethodCardData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The brand property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Brand { get; set; }
#nullable restore
#else
        public string Brand { get; set; }
#endif
        /// <summary>The exp_month property</summary>
        public int? ExpMonth { get; set; }
        /// <summary>The exp_year property</summary>
        public int? ExpYear { get; set; }
        /// <summary>The last4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Last4 { get; set; }
#nullable restore
#else
        public string Last4 { get; set; }
#endif
        /// <summary>The wallet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet? Wallet { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet Wallet { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PaymentMethodCardData"/> and sets the default values.
        /// </summary>
        public PaymentMethodCardData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PaymentMethodCardData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PaymentMethodCardData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PaymentMethodCardData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "brand", n => { Brand = n.GetStringValue(); } },
                { "exp_month", n => { ExpMonth = n.GetIntValue(); } },
                { "exp_year", n => { ExpYear = n.GetIntValue(); } },
                { "last4", n => { Last4 = n.GetStringValue(); } },
                { "wallet", n => { Wallet = n.GetObjectValue<global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet>(global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("brand", Brand);
            writer.WriteIntValue("exp_month", ExpMonth);
            writer.WriteIntValue("exp_year", ExpYear);
            writer.WriteStringValue("last4", Last4);
            writer.WriteObjectValue<global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet>("wallet", Wallet);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::ApiSdk.Models.PaymentMethodCardData_walletMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PaymentMethodCardData_wallet : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::ApiSdk.Models.PaymentMethodCardData_walletMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::ApiSdk.Models.PaymentMethodCardData_walletMember1? PaymentMethodCardDataWalletMember1 { get; set; }
#nullable restore
#else
            public global::ApiSdk.Models.PaymentMethodCardData_walletMember1 PaymentMethodCardDataWalletMember1 { get; set; }
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
            /// <returns>A <see cref="global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::ApiSdk.Models.PaymentMethodCardData.PaymentMethodCardData_wallet();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.PaymentMethodCardDataWalletMember1 = new global::ApiSdk.Models.PaymentMethodCardData_walletMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(PaymentMethodCardDataWalletMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(PaymentMethodCardDataWalletMember1);
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
                    writer.WriteObjectValue<global::ApiSdk.Models.PaymentMethodCardData_walletMember1>(null, PaymentMethodCardDataWalletMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
