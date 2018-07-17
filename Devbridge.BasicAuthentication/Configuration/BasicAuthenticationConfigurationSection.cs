using System.Configuration;

namespace Devbridge.BasicAuthentication.Configuration
{
    public class BasicAuthenticationConfigurationSection : ConfigurationSection
    {
        private const string CredentialsNode = "credentials";
        private const string WhiteListNode = "whitelist";

        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>
        /// The credentials.
        /// </value>
        [ConfigurationProperty(CredentialsNode, IsRequired = false)]
        public CredentialElementCollection Credentials
        {
            get { return (CredentialElementCollection)this[CredentialsNode]; }
            set { this[CredentialsNode] = value; }
        }

        

        /// <summary>
        /// Gets or sets a value indicating whether authenticaiton module should allow local requests without issuing auth challenge.
        /// </summary>
        /// <value>
        ///   <c>true</c> to allow redirects; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("allowLocal", DefaultValue = "true", IsRequired = false)]
        public bool AllowLocal
        {
            get { return (bool)this["allowLocal"]; }
            set { this["allowLocal"] = value; }
        }

        /// <summary>
        /// Gets or sets the URL exclusions.
        /// </summary>
        /// <value>
        /// The URL exclusions.
        /// </value>
        [ConfigurationProperty(WhiteListNode, IsRequired = false)]
        public WhiteListElementCollection WhiteList
        {
            get { return (WhiteListElementCollection)this[WhiteListNode]; }
            set { this[WhiteListNode] = value; }
        }
    }
}