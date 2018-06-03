using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    [Serializable]
    public sealed class StorageDepartmentDTO : DepartmentDTO
    {
        public List<RobotMachine> MachineList { get; set; }

        public StorageDepartmentDTO()
        { }

        public StorageDepartmentDTO(List<RobotMachine> machinelList, string name, List<string> pipleList, List<ProductionDTO> productionList)
            : base(name, pipleList, productionList)
        {
            if (machinelList == null)
                throw new ArgumentException("Список авт. систем не должен быть пустым");
            MachineList = machinelList;
        }
    }
}

