using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public class CreateIndustryController
    {      
        private Industry _industry;

        public Industry Indusrty
        {
            get { return _industry; }
            set
            {
                _industry = value;
            }
        }
       
        public StringBuilder Report => CanMakeIndustry ? GetInfo() : null;                  
       
        public StringBuilder GetInfo()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Название: {Indusrty.NameIndusry}\nКол-во цехов: {Indusrty.Departaments.Count}\n\n");
           
            for(int i=0;i<Indusrty.Departaments.Count; i++)
            {
                str.Append($"{i + 1}.{Indusrty.Departaments[i].NameDepartment}\n");               
                str.Append("Список рабочих:\n");             
                for (int j = 0; j < Indusrty.Departaments[i].PipleList.Count; j++)
                {
                    str.Append($"{j + 1}.{Indusrty.Departaments[i].PipleList[j]}\n");
                }
                str.Append($"Общее число рабочих:{Indusrty.Departaments[i].CountPiples}\n");
                str.Append($"Число наименований продукции:{Indusrty.Departaments[i].CountNameProductions}\n");
                str.Append($"Производительность цеха:{Indusrty.Departaments[i].Productivity}\n\n");
            }
            
            return str;
        }

        public bool CanRemoveDepartament => Indusrty.Departaments.Count > 0;
        public bool CanReport => Indusrty.Departaments.Count > 0 && Indusrty.NameIndusry != null;
        public bool CanMakeIndustry => Indusrty.Departaments.Count> 0 && Indusrty.NameIndusry!=null;

        public CreateIndustryController(Industry industry)
        {
            _industry = industry;          
        }

        public void InitializeIndustry()
        {
            var industry = new Industry();
            industry = InitIndustry.InitializeOrganization(industry);
            _industry = industry;                   
        }
       
        public void AddDepartment(Department newDepartment)
        {
            _industry.AddDepartment(newDepartment);
        }

        public void RemoveDepartment(int index)
        {
            _industry.RemoveDepartment(index);
        }       
    }
}

