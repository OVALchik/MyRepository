using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPlaba2
{
    public partial class CreateProduction : Form
    {
        private readonly CreateProductionController _controller;
        public event EventHandler UpdateForm;

        public CreateProduction(CreateProductionController controller)
        {
            InitializeComponent();
            _controller = controller;

            comboBoxTypeMaterial.Enabled = _controller.EnableTypeMaterial;
            comboBoxTypeProduction.Enabled = _controller.EnableTypeProduction;         
            buttonRemoveProduction.Enabled = _controller.CanRemoveProduction;
            ShowTypeProduction();
            GetTypeMaterial();
            GetTypeProduction();
            UpdateForm += OnUpdateForm;
            _controller.PropertyChanged += _controller_PropertyChanged;
        }

        public void GetTypeMaterial()
        {
            foreach (var t in _controller.TypesMaterial)
                comboBoxTypeMaterial.Items.Add(t);
        }

        public void GetTypeProduction()
        {
            foreach (var t in _controller.TypesProduction)
                comboBoxTypeProduction.Items.Add(t);
        }

        public void ShowProductionList()
        {
            if (_controller.ProductionList != null)
            {
                foreach (var product in _controller.ProductionList)
                    listBoxProduction.Items.Add(product);
            }

        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            ShowProductionList();
            textBoxNameProduction.Clear();
            textBoxLength.Clear();
            textBoxWidth.Clear();
            textBoxHight.Clear();
            textBoxWeight.Clear();
            textBoxCount.Clear();                                            
        }

        private void ShowTypeProduction()
        {
            if (_controller.Department.GetType() == typeof(StorageDepartment))
            {
                textBoxTypeProduct.Text = "Первичная";
            }
            if (_controller.Department.GetType() == typeof(ProcessingDepartment))
            {
                textBoxTypeProduct.Text = "Вторичная";
            }
            if (_controller.Department.GetType() == typeof(AssemblyDepartment))
            {
                textBoxTypeProduct.Text = "Финальная";
            }            
        }

        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.CanSave))
                buttonSave.Enabled = _controller.CanSave;

            if (e.PropertyName == nameof(_controller.CanRemoveProduction))
                buttonRemoveProduction.Enabled = _controller.CanRemoveProduction;
        }

        public Production CreateProductions()
        {            
            if (_controller.Department.GetType() == typeof(StorageDepartment))
            {
                _controller.Production = new PrimaryProduction(
                (TypeMaterial)Enum.Parse(typeof(TypeMaterial), comboBoxTypeMaterial.Text),
                (TypeProduction)Enum.Parse(typeof(TypeProduction), comboBoxTypeProduction.Text),
                textBoxNameProduction.Text,
                new Size(Convert.ToDouble(textBoxLength.Text),
                Convert.ToDouble(textBoxWidth.Text), Convert.ToDouble(textBoxHight.Text),
                Convert.ToDouble(textBoxWeight.Text)),
                Convert.ToInt32(textBoxCount.Text)
                );
            }

            if (_controller.Department.GetType() == typeof(ProcessingDepartment))
            {
                _controller.Production = new SecondaryProduction(
                textBoxNameProduction.Text,
                new Size(Convert.ToDouble(textBoxLength.Text),
                Convert.ToDouble(textBoxWidth.Text), Convert.ToDouble(textBoxHight.Text),
                Convert.ToDouble(textBoxWeight.Text)),
                (TypeMaterial)Enum.Parse(typeof(TypeMaterial), comboBoxTypeMaterial.Text),
                Convert.ToInt32(textBoxCount.Text));
            }

            if (_controller.Department.GetType() == typeof(ProcessingDepartment))
            {
                _controller.Production = new FinalProduction(
                textBoxNameProduction.Text,
                new Size(Convert.ToDouble(textBoxLength.Text),
                Convert.ToDouble(textBoxWidth.Text), Convert.ToDouble(textBoxHight.Text),
                Convert.ToDouble(textBoxWeight.Text)),
                Convert.ToInt32(textBoxCount.Text));
            }

            return _controller.Production;
        }
/*
        public SecondaryProduction CreateSecondaryProduction()
        {
            _controller.SecondaryProduction = new SecondaryProduction(
                textBoxNameProduction.Text, 
                new Size(Convert.ToDouble(textBoxLength.Text),
                Convert.ToDouble(textBoxWidth.Text), Convert.ToDouble(textBoxHight.Text),
                Convert.ToDouble(textBoxWeight.Text)),
                (TypeMaterial)Enum.Parse(typeof(TypeMaterial), comboBoxTypeMaterial.Text),
                Convert.ToInt32(textBoxCount.Text));          

            return _controller.SecondaryProduction;
        }

        public FinalProduction CreateFinalProduction()
        {
            _controller.FinalProduction = new FinalProduction(
                textBoxNameProduction.Text,
                new Size(Convert.ToDouble(textBoxLength.Text),
                Convert.ToDouble(textBoxWidth.Text), Convert.ToDouble(textBoxHight.Text),
                Convert.ToDouble(textBoxWeight.Text)),
                Convert.ToInt32(textBoxCount.Text));

            return _controller.FinalProduction;
        }
*/
        private void buttonAddProduction_Click(object sender, EventArgs e)
        {
            listBoxProduction.Items.Add(textBoxNameProduction.Text);
            _controller.AddProduction(CreateProductions());
            /*
             if (_controller.Department.GetType() == typeof(StorageDepartment))
             {             
                 _controller.AddProduction(CreatePrimaryProduction());               
             }

             if (_controller.Department.GetType() == typeof( ProcessingDepartment))
             {               
                 _controller.AddProduction(CreateSecondaryProduction());
             }

             if (_controller.Department.GetType() == typeof(AssemblyDepartment))
             {
                 _controller.AddProduction(CreateFinalProduction());
             }
             */
            UpdateForm?.Invoke(this, e);

        }            

        private void buttonRemoveProduction_Click(object sender, EventArgs e)
        {
            _controller.RemoveProduction(listBoxProduction.SelectedIndex);
            listBoxProduction.Items.RemoveAt(listBoxProduction.SelectedIndex);
           
            UpdateForm?.Invoke(this, e);
        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            _controller.InitializeIndustry();
            UpdateForm?.Invoke(this, e);
        }
    }
}
