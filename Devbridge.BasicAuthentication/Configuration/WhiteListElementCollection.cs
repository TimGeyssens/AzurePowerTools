using System.Configuration;

namespace Devbridge.BasicAuthentication.Configuration
{
    [ConfigurationCollection(typeof(WhiteListElement), CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class WhiteListElementCollection : ConfigurationElementCollection
    {
        public WhiteListElement this[int index]
        {
            get
            {
                return (WhiteListElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new WhiteListElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((WhiteListElement)element).ToString();
        }
    }
}
