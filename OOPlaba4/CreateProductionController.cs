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
    {
        private List<Production> _productionList;
        private TypeMaterial _material;
        private TypeProduction _productionType;

        public TypeMaterial Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;             
            }
        }

        public TypeProduction ProductionType
        {
            get
            {
                return _productionType;
            }
            set
            {
                _productionType = value;
            }            
        }
        
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
        }
       
        public List<TypeMaterial> TypesMaterial { get; }
        public List<TypeProduction> TypesProduction { get; }

        public CreateProductionController(List<Production> productions)
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

            ProductionList = productions;
        }

        public void AddProduction(Production product)
        {
            _productionList.Add(product);
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

        public bool CanRemoveProduct => ProductionList != null;

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public List<Production> ProductList => CanSave ? ProductionList : null;      

        public bool CanSave => ProductionList != null;

        public bool CanRemoveProduction => ProductionList!=null;

        public bool CanMakeProduction => ProductionList != null;
       
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
