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
    public partial class CreateIndustry : Form
    {
        private readonly CreateIndustryController _controller;
        public event EventHandler UpdateForm;
               
        public CreateIndustry(CreateIndustryController controller)
        {
            InitializeComponent();
            _controller = controller;
            UpdateForm += OnUpdateForm;
           
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            textBoxNameIndustry.Text = _controller.NameIndustry;
            ShowDepartments();          
            EnableRemoveDepartmentButton();                
        }

        private void ShowDepartments()
        {
            comboBoxDepartmentList.Items.Clear();
            foreach (var dep in _controller.Departments)
            {
                comboBoxDepartmentList.Items.Add(dep.NameDepartment);
            }
        }      

        private Department GetDepartmen()
        {
            if (radioButtonStorage.Checked)
                return new StorageDepartment();
            if (radioButtonProcessing.Checked)
                return new ProcessingDepartment();
            if (radioButtonAssembly.Checked)
                return new AssemblyDepartment();
            return null;
        }

        private void EnableRemoveDepartmentButton()
        {
            buttonRemoveDepartment.Enabled = _controller.CanRemoveDepartament;
        }      

        private void buttonInit_Click(object sender, EventArgs e)
        {
            _controller.InitializeIndustry();           
            UpdateForm?.Invoke(this, e);
        }
        
        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {                       
            var newDepartmentController = new CreateDepartmentController(GetDepartmen(),_controller.Indusrty);
            var formDepartment = new CreateDepartment(newDepartmentController);
            if (formDepartment.ShowDialog() == DialogResult.OK)
            {
                var newDepartment = newDepartmentController.Department;
                _controller.AddDepartment(newDepartment);
            }
            ShowDepartments();  
        }

        private void comboBoxDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartmentList.SelectionLength== 0)
                return;
            var item = comboBoxDepartmentList.SelectedIndex;
            _controller.SelectDepartment(item);
            UpdateForm?.Invoke(this, e);
        }
        private void buttonRemoveDepartment_Click(object sender, EventArgs e)
        {
            var item = comboBoxDepartmentList.SelectedIndex;
            _controller.RemoveDepartment(item);
            comboBoxDepartmentList.SelectedIndex=-1;
            UpdateForm?.Invoke(this, e);
        }       

        private void buttonMakeIndustry_Click(object sender, EventArgs e)
        {
            if (textBoxNameIndustry != null)
                Close();
        }

        
        /*
private void reportButton_Click(object sender, EventArgs e)
{
   reportTextBox.Text = _controller.Report;
}

*/
    }
}
