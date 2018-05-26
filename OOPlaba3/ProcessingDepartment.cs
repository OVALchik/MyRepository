using System.Collections.Generic;

namespace OOPlaba2
{
    public sealed class ProcessingDepartment : Department
    {

        public ProcessingDepartment(string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {

        }

    }
}
