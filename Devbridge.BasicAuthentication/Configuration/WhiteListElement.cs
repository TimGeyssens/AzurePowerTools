using System;
using System.Configuration;

namespace Devbridge.BasicAuthentication.Configuration
{
    public class WhiteListElement : ConfigurationElement
    {
        private const string IpAttribute = "ip";

      
        [ConfigurationProperty(IpAttribute, IsRequired = true, IsKey = false)]
        public string Ip
        {
            get { return Convert.ToString(this[IpAttribute]); }
            set { this[IpAttribute] = value; }
        }


        public override string ToString()
        {
            return Ip;
        }
    }
}
