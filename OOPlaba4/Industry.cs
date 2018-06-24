using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPlaba2
{
    [Serializable]
    public  class Industry
    {      
        public string NameIndusry { get; set; }
        public List<Department> Departaments { get; set; } = new List<Department>();

        public Industry()
        { }

        public Industry(string name, List<Department> departmentList)
        {
            if(departmentList == null)
                throw new ArgumentException("На производстве должен быть хотя бы один цех");

            NameIndusry = name;
            Departaments = departmentList;
        }             

        public void AddDepartment(Department departaments)
        {
            Departaments.Add(departaments);
        }

        public void RemoveDepartment(int index)
        {            
            try
            {              
                Departaments.RemoveAt(index);
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
        }

        public void EditDepartment(int index, Department departaments)
        {
            try
            {
                Departaments[index] = departaments;
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }
            
        }
        
    }
}
