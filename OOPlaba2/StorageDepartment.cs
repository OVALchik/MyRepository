using System;
using System.Collections.Generic;

namespace OOPlaba2
{
    public sealed class StorageDepartment : Department
    {      
        public List<RobotMachine> MachineList { get; private set; }

        public StorageDepartment(List<RobotMachine> machinelList, string name, List<string> pipleList, List<Production> productionList)
            : base(name, pipleList, productionList)
        {
            MachineList = machinelList;
        }             
    }
}
