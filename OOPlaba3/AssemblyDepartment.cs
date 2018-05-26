using System.Collections.Generic;

namespace OOPlaba2
{
    public sealed class AssemblyDepartment : Department
    {
        public AssemblyDepartment(string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {

        }

    }
}
