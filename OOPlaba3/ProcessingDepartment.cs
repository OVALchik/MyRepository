using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    //[Serializable]
    public sealed class ProcessingDepartmentDTO : DepartmentDTO
    {
        public ProcessingDepartmentDTO()
        { }

        public ProcessingDepartmentDTO(string name, List<string> pipleList, List<ProductionDTO> productionList)
            : base(name, pipleList, productionList)
        {

        }


    }
}
