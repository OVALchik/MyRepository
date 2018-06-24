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

        public string NameIndustry => _industry.NameIndusry;
        public List<Department> Departments => _industry.Departaments ?? new List<Department>();
        public Department SelectedDepartment { get; set; }


        public Industry Indusrty
        {
            get { return _industry; }
        }

        public Department Department { get; set; }

        public string Report => IsSet
            ? $"Название производства:{_industry.NameIndusry} " +             
              $"Кол-во цехов:{_industry.Departaments.Count}": " ";                  
       
        public bool CanRemoveDepartament => Departments.Count <= 0;
   
        private bool IsSet => _industry != null;

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

        public void SelectDepartment(int index)
        {
            SelectedDepartment = Departments[index];
        }

        public void RemoveDepartment(int index)
        {
            _industry.RemoveDepartment(index);
        }

       

        
    }
}

