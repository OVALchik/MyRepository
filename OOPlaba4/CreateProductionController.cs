using System;
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
    public class CreateProductionController: INotifyPropertyChanged
    {/*
        private string _nameProduction;
        private Size _size;
        private double _lenght;
        private double _width;
        private double _hight;
        private double _weight;
        private int? _count;
        private FinalProduction _finalProduction;
        public List<FinalProduction> _finalProductions;
        private PrimaryProduction _primaryProduction;
        public List<SecondaryProduction> _seconaryProductions;
        public List<PrimaryProduction> _primaryProductions;
        private SecondaryProduction _seconaryProduction;
        private Production _production;
        private List<Production> _productionList;

        public TypeMaterial Material;

        public TypeProduction ProductionType;

        public string NameProduction
        {
            get
            {
                return _nameProduction;
            }
            set
            {
                _nameProduction = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                _lenght = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public double Hight
        {
            get
            {
                return _hight;
            }
            set
            {
                _hight = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public int? Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        */
        public PrimaryProduction PrimaryProduction
        {
            get
            {
                return _primaryProduction;
            }
            set
            {
                _primaryProduction = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        
        private FinalProduction _finalProduction;
        public List<FinalProduction> _finalProductions;
        private PrimaryProduction _primaryProduction;
        public List<SecondaryProduction> _seconaryProductions;
        public List<PrimaryProduction> _primaryProductions;
        private SecondaryProduction _seconaryProduction;
        private Production _production;
        private List<Production> _productionList;

        public List<PrimaryProduction> PrimaryProductions
        {
            get
            {
                return _primaryProductions;
            }
            set
            {
                _primaryProductions =value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        
        public SecondaryProduction SecondaryProduction
        {
            get
            {
                return _seconaryProduction;
            }
            set
            {
                _seconaryProduction = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        
        public List<SecondaryProduction> SecondaryProductions
        {
            get
            {
                return _seconaryProductions;
            }
            set
            {
                _seconaryProductions = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        
        public FinalProduction FinalProduction
        {
            get
            {
                return _finalProduction;
            }
            set
            {
                _finalProduction = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
       
        public List<FinalProduction> FinalProductions
        {
            get
            {
                return _finalProductions;
            }
            set
            {
                _finalProductions = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        
        public Production Production
        {
            get
            {
                return _production;
            }
            set
            {
                _production = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }
        /*
        public Size Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = GetSize();
                OnPropertyChanged(nameof(CanSave));
            }
        }
        */
        public List<Production> ProductionList
        {
            get
            {
                return _productionList;
            }
            set
            {
                _productionList = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }//наш рабочий
       
        public Department Department { get; }

        public List<PrimaryProduction> PrimaryProductList => CanSave ? PrimaryProductions : null;
        public List<SecondaryProduction> SecondaryProductList => CanSave ? SecondaryProductions : null;
        public List<FinalProduction> FinalProductList => CanSave ? FinalProductions : null;
        /*
        public List<PrimaryProduction> PrimaryProduct => CanSave
            ? new PrimaryProduction(Material, ProductionType ,NameProduction, 
                new Size(Lenght, Width,Hight,Weight),Count.Value)              
            : null;

        public SecondaryProduction SecondaryProduct => CanSave
            ? new SecondaryProduction(NameProduction,
                new Size(Lenght, Width, Hight, Weight), Material, Count.Value)
            : null;

        public FinalProduction FinalProduct => CanSave
            ? new FinalProduction(NameProduction,
                new Size(Lenght, Width, Hight, Weight), Count.Value)
            : null;

        public Size GetSize()
        {
            var size = new Size(Lenght, Width, Hight, Weight);           
            return size;
        }
        */
        public List<TypeMaterial> TypesMaterial { get; }
        public List<TypeProduction> TypesProduction { get; }

        public CreateProductionController(Department newdepartment)
        {
            TypesProduction = new List<TypeProduction>();
            foreach (var t in Enum.GetValues(typeof(TypeProduction)).Cast<TypeProduction>().ToList())
            {
                TypesProduction.Add(t);
            }

            TypesMaterial = new List<TypeMaterial>();
            foreach (var t in Enum.GetValues(typeof(TypeMaterial)).Cast<TypeMaterial>().ToList())
            {
                    TypesMaterial.Add(t);                
            }

            ProductionList = newdepartment.Productions;
            Department = newdepartment;
        }

        public bool EnableTypeProduction => Department is StorageDepartment;
        public bool EnableTypeMaterial => Department is StorageDepartment || Department is ProcessingDepartment;         
       
        public void AddProduction(Production product)
        {
            ProductionList.Add(product);
        }

        public void RemoveProduction(int index)
        {
            try
            {
                _productionList.RemoveAt(index);
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }

        }

        public void InitializeIndustry()
        {          
            if(Department is StorageDepartment)
                PrimaryProductions = InitIndustry.CreatePrimaryProduction();

            if (Department is ProcessingDepartment)
                SecondaryProductions = InitIndustry.CreateSecondaryProduction();

            if (Department is AssemblyDepartment)
                FinalProductions = InitIndustry.CreateFinalProduction();

        }

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public List<Production> ProductList => CanSave ? ProductionList : null;
        
        public bool CanSave => ProductionList != null;
        public bool CanRemoveProduction => ProductionList!=null;     

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
