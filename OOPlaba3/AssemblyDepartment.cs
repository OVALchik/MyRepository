using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    //[Serializable]
    public sealed class AssemblyDepartmentDTO : DepartmentDTO
    {
        public AssemblyDepartmentDTO()
        { }

        public AssemblyDepartmentDTO(string name, List<string> pipleList, List<ProductionDTO> productionList)
            : base(name, pipleList, productionList)
        {

        }

    }
}
