using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    [Serializable]
    public sealed class StorageDepartment : Department
    {
        public List<RobotMachine> MachineList { get; set; }

        public StorageDepartment()
        { }

        public StorageDepartment(List<RobotMachine> machinelList, string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {
            if (machinelList == null)
                throw new ArgumentException("Список авт. систем не должен быть пустым");
            MachineList = machinelList;
        }
    }
}

