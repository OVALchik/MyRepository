using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPlaba2
{
    public class CreatePipleListController: INotifyPropertyChanged
    {
        private List<string> _fio;

        public List<string> FIO
        {
            get
            {
                return _fio;
            }
            set
            {
                _fio = value;
                OnPropertyChanged(nameof(CanSave));
            }
        }

        public CreatePipleListController(List<string> piples)
        {
            FIO = piples;
        }
       
        public void AddPiple(string piple)
        {
            _fio.Add(piple);
        }

        public void RemovePiple(int index)
        {
            try
            {
                FIO.RemoveAt(index);
            }
            catch (Exception)
            {
                throw new ArgumentException("Неверный индекс");
            }

        }

        public void InitializeIndustry()
        {
            var pipleList = new List<string>();
            pipleList = InitIndustry.CreatePipleListForStorageDepartment();
            _fio = pipleList;
        }

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public List<string> PipleList => CanSave ? FIO : null;

        public bool CanSave => FIO != null;
        public bool CanRemovePiple => FIO != null;       

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
