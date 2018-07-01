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

            GetTypeMaterial();
            GetTypeProduction();
            ShowProduction();

            UpdateForm += OnUpdateForm;         
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

       
        private void EnableRemoveProductionButton()
        {
            buttonRemoveProduct.Enabled = _controller.CanRemoveProduction;
        }

        private void EnableMakeProductionButton()
        {
            buttonCreateProducions.Enabled = _controller.CanMakeProduction;
        }

        public void ShowProduction()
        {
            if (_controller.ProductionList != null)
            {
                listBoxNameProduct.Items.Clear();
                foreach (var product in _controller.ProductionList)
                    listBoxNameProduct.Items.Add(product.NameProduction);
            }

        }
        private void OnUpdateForm(object sender, EventArgs e)
        {
            textBoxNameProduction.Clear();
            comboBoxTypeMaterial.SelectedIndex = -1;
            textBoxLength.Clear();
            textBoxWidth.Clear();
            textBoxHight.Clear();
            textBoxWeight.Clear();
            textBoxCount.Clear();
            ShowProduction();
            EnableRemoveProductionButton();
            EnableMakeProductionButton();
            listBoxNameProduct.SelectedItem = null;
            comboBoxTypeProduction.SelectedIndex = -1;
        }
        
        private void buttonAddProduction_Click(object sender, EventArgs e)
        {
            int numberInt = 0;
            double numberDouble = 0;
            errorProvider1.Clear();
            
            if (comboBoxTypeMaterial.SelectedIndex == -1 || comboBoxTypeProduction.SelectedIndex == -1)
                errorProvider1.SetError(comboBoxTypeMaterial,"Не выбран материал или тип продукции");
            else if(!Int32.TryParse(textBoxCount.Text,out numberInt) || !double.TryParse(textBoxHight.Text, out numberDouble) 
                || !double.TryParse(textBoxLength.Text, out numberDouble) || !double.TryParse(textBoxWidth.Text, out numberDouble) 
                || !double.TryParse(textBoxWeight.Text, out numberDouble))
                errorProvider1.SetError(textBoxCount, "Не верно указано значение: габариты или количество продукции");
            else if (string.IsNullOrEmpty(textBoxNameProduction.Text))
                errorProvider1.SetError(textBoxNameProduction, "Не указано имя");
            else
            {
                listBoxNameProduct.Items.Add(textBoxNameProduction.Text);
                _controller.AddProduction(new Production((TypeMaterial)Enum.Parse(typeof(TypeMaterial), comboBoxTypeMaterial.Text),
                     (TypeProduction)Enum.Parse(typeof(TypeProduction), comboBoxTypeProduction.Text),
                     textBoxNameProduction.Text,
                     new Size(Convert.ToDouble(textBoxLength.Text),
                     Convert.ToDouble(textBoxWidth.Text),
                     Convert.ToDouble(textBoxHight.Text),
                     Convert.ToDouble(textBoxWeight.Text)),
                     Convert.ToInt32(textBoxCount.Text)));

                UpdateForm?.Invoke(this, e);
            }                   
        }             

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (listBoxNameProduct.Items.Count == 0)
                errorProvider1.SetError(listBoxNameProduct, "Список пуст");
            else
            {
                _controller.RemoveProduction(listBoxNameProduct.SelectedIndex);
                listBoxNameProduct.Items.RemoveAt(listBoxNameProduct.SelectedIndex);
                UpdateForm?.Invoke(this, e);
            }
        }

        private void buttonCreateProducions_Click(object sender, EventArgs e)
        {                       
            DialogResult = DialogResult.OK;
            Close();
        }
    }
     
    
}
