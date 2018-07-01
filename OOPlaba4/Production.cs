using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OOPlaba2
{
    [Serializable]
    public class Production 
    {
        public TypeMaterial Material { get; set; }
        public TypeProduction Type { get; set; }
        public string NameProduction { get; set; }
        public Size SizeProduction { get; set; }
        public int CountProduction { get; set; }

        public Production()
        { }

        public Production(TypeMaterial typeMaterial, TypeProduction typeProduction, string name, Size size, int count)         
        {
            NameProduction = name;
            SizeProduction = size;
            CountProduction = count;
            Material = typeMaterial;
            Type = typeProduction;
        }
    }   
}
