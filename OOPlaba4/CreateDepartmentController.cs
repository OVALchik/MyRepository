using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPlaba2
{
    public class CreateDepartmentController
    {
        private Department _department;

        private TypeDepartment _type;
        private List<RobotMachine> _robotMachines;
        private string _nameDepartment;
        private List<string> _pipleList;
        private List<Production> _productionList;
      
        public Department Department => CanSave ? CreateDepartment (): null;
      
        public TypeDepartment TypeDepartament
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }

        public Department Departament
        {
            get { return _department; }
            set
            {
                _department = value;
            }
        }     

        public List<RobotMachine> Robot
        {
            get { return _robotMachines; }
            set
            {
                _robotMachines = value;
            }
        }

        public string NameDepartment
        {
            get { return _nameDepartment; }
            set
            {
                _nameDepartment = value;
            }
        }

        public List<string> PipleList
        {
            get { return _pipleList; }
            set
            {
                _pipleList = value;
            }
        }

        public List<Production> ProductionList
        {
            get { return _productionList; }
            set
            {
                _productionList = value;
            }
        }

        public Department CreateDepartment()
        {
            if (TypeDepartament == TypeDepartment.StorageDepartment)
                Departament = new StorageDepartment(Robot, NameDepartment, PipleList, ProductionList);
            if (TypeDepartament == TypeDepartment.ProcessingDepartment)
                Departament = new ProcessingDepartment(NameDepartment, PipleList, ProductionList);
            if (TypeDepartament == TypeDepartment.AssemblyDepartment)
                Departament = new AssemblyDepartment(NameDepartment, PipleList, ProductionList);
            return Departament;        
        }

        public CreateDepartmentController(TypeDepartment type)
        {
            _type = type;          
        }
        
        public bool VisibleRobotCreate => TypeDepartament == TypeDepartment.StorageDepartment;

        public bool CanSave =>
            !string.IsNullOrWhiteSpace(NameDepartment)
            && PipleList != null
            && ProductionList != null;      

        public void InitializeRobot()
        {
            var robot = new List<RobotMachine>();
            robot = InitIndustry.CreateRobotMachine();
            _robotMachines = robot;
        }

        public void InitializeProductions()
        {
            var productions = new List<Production>();
            productions = InitIndustry.CreateProduction();
            _productionList = productions;
        }

        public void InitializePiples()
        {
            var pipleList = new List<string>();
            pipleList = InitIndustry.CreatePipleListForStorageDepartment();
            _pipleList = pipleList;
        }       
    }
}
