using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    [Serializable]
    public sealed class ProcessingDepartment : Department
    {
        public ProcessingDepartment()
        { }

        public ProcessingDepartment(string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {

        }


    }
}
