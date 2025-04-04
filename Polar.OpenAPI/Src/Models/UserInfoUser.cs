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
    public partial class UserInfoUser : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email? Email { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email Email { get; set; }
#endif
        /// <summary>The email_verified property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified? EmailVerified { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified EmailVerified { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name? Name { get; set; }
#nullable restore
#else
        public global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name Name { get; set; }
#endif
        /// <summary>The sub property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sub { get; set; }
#nullable restore
#else
        public string Sub { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Polar.OpenAPI.Models.UserInfoUser"/> and sets the default values.
        /// </summary>
        public UserInfoUser()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Polar.OpenAPI.Models.UserInfoUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Polar.OpenAPI.Models.UserInfoUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Polar.OpenAPI.Models.UserInfoUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email", n => { Email = n.GetObjectValue<global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email>(global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email.CreateFromDiscriminatorValue); } },
                { "email_verified", n => { EmailVerified = n.GetObjectValue<global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified>(global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetObjectValue<global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name>(global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name.CreateFromDiscriminatorValue); } },
                { "sub", n => { Sub = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email>("email", Email);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified>("email_verified", EmailVerified);
            writer.WriteObjectValue<global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name>("name", Name);
            writer.WriteStringValue("sub", Sub);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.UserInfoUser_emailMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserInfoUser_email : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.UserInfoUser_emailMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.UserInfoUser_emailMember1? UserInfoUserEmailMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.UserInfoUser_emailMember1 UserInfoUserEmailMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.UserInfoUserEmailMember1 = new global::Polar.OpenAPI.Models.UserInfoUser_emailMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(UserInfoUserEmailMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(UserInfoUserEmailMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.UserInfoUser_emailMember1>(null, UserInfoUserEmailMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="bool"/>, <see cref="global::Polar.OpenAPI.Models.UserInfoUser_email_verifiedMember1"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserInfoUser_email_verified : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="bool"/></summary>
            public bool? Boolean { get; set; }
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.UserInfoUser_email_verifiedMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.UserInfoUser_email_verifiedMember1? UserInfoUserEmailVerifiedMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.UserInfoUser_email_verifiedMember1 UserInfoUserEmailVerifiedMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_email_verified();
                if(parseNode.GetBoolValue() is bool booleanValue)
                {
                    result.Boolean = booleanValue;
                }
                else {
                    result.UserInfoUserEmailVerifiedMember1 = new global::Polar.OpenAPI.Models.UserInfoUser_email_verifiedMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(UserInfoUserEmailVerifiedMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(UserInfoUserEmailVerifiedMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.UserInfoUser_email_verifiedMember1>(null, UserInfoUserEmailVerifiedMember1);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Polar.OpenAPI.Models.UserInfoUser_nameMember1"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UserInfoUser_name : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Polar.OpenAPI.Models.UserInfoUser_nameMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Polar.OpenAPI.Models.UserInfoUser_nameMember1? UserInfoUserNameMember1 { get; set; }
#nullable restore
#else
            public global::Polar.OpenAPI.Models.UserInfoUser_nameMember1 UserInfoUserNameMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Polar.OpenAPI.Models.UserInfoUser.UserInfoUser_name();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else {
                    result.UserInfoUserNameMember1 = new global::Polar.OpenAPI.Models.UserInfoUser_nameMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(UserInfoUserNameMember1 != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(UserInfoUserNameMember1);
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
                    writer.WriteObjectValue<global::Polar.OpenAPI.Models.UserInfoUser_nameMember1>(null, UserInfoUserNameMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
