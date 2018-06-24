using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OOPlaba2
{
    [XmlInclude(typeof(PrimaryProduction))]
    [XmlInclude(typeof(FinalProduction))]
    [XmlInclude(typeof(SecondaryProduction))]
    [Serializable]
    public abstract class Production
    {       
        public string NameProduction { get; set; }
        public Size SizeProduction { get; set; }
        public int CountProduction { get; set; }       

        protected Production()
        { }

        protected Production(string name, Size size, int count)
        {
            NameProduction = name;
            SizeProduction = size;
            CountProduction = count;            
        }

            public abstract void ShowInfoProduction();

        public static explicit operator Production(List<PrimaryProduction> v)
        {
            throw new NotImplementedException();
        }
    }    
}
