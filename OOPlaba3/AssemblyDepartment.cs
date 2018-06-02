using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    [Serializable]
    public sealed class AssemblyDepartment : Department
    {
        public AssemblyDepartment()
        { }

        public AssemblyDepartment(string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {

        }

    }
}
