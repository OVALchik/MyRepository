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
        private Industry _industry;

        private List<RobotMachine> _robotMachines;
        private string _nameDepartment;
        private List<string> _pipleList;
        private List<Production> _productionList;

       
        /*
        public Department Department => CanSave
            ? (Departament is StorageDepartment ? new StorageDepartment(Robot, NameDepartment, PipleList,ProductionList) :
                (Departament is ProcessingDepartment ? (Department) new ProcessingDepartment(NameDepartment, PipleList, ProductionList) : 
                     new AssemblyDepartment(NameDepartment, PipleList, ProductionList))) :  null;*/
        public Department Department => CanSave ? Departament: null;

        public Industry Industry
        {
            get { return _industry; }           
        }

        public Department Departament
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }     

        public List<RobotMachine> Robot
        {
            get { return _robotMachines; }
            set
            {
                _robotMachines = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public string NameDepartment
        {
            get { return _nameDepartment; }
            set
            {
                _nameDepartment = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public List<string> PipleList
        {
            get { return _pipleList; }
            set
            {
                _pipleList = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public List<Production> ProductionList
        {
            get { return _productionList; }
            set
            {
                _productionList = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        
        public bool VisibleRobotCreate => Departament is StorageDepartment;
        
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

        public event PropertyChangedEventHandler PropertyChanged;

        //  [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public CreateDepartmentController(Department department, Industry industry)
        {
            _department = department;
            _industry = industry;
        }



    }
}
