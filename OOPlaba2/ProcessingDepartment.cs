﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
