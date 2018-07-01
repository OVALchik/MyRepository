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
            textBoxNameIndustry.Text = _controller.Indusrty.NameIndusry;
            listBoxDepartments.SelectedItem = null;
            ShowDepartments();          
            EnableRemoveDepartmentButton();
            EnableReportDepartmentButton();
        }

        private void ShowDepartments()
        {
            if (_controller.Indusrty.Departaments!=null)
            {
                listBoxDepartments.Items.Clear();
                foreach (var dep in _controller.Indusrty.Departaments)
                    listBoxDepartments.Items.Add(dep.NameDepartment);             
            }
           
        }

        private TypeDepartment GetTypeDepartmen()
        {
            if (radioButtonStorage.Checked)
                return TypeDepartment.StorageDepartment;
            if (radioButtonProcessing.Checked)
                return TypeDepartment.ProcessingDepartment;
            if (radioButtonAssembly.Checked)
                return TypeDepartment.AssemblyDepartment;
            return TypeDepartment.None;
        }

        private void EnableRemoveDepartmentButton()
        {
            buttonRemoveDepartment.Enabled = _controller.CanRemoveDepartament;
        }

        private void EnableReportDepartmentButton()
        {
            buttonInfo.Enabled = _controller.CanReport;
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            _controller.InitializeIndustry();           
            UpdateForm?.Invoke(this, e);
        }
        
        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (GetTypeDepartmen()==TypeDepartment.None)
                errorProvider1.SetError(groupBox1, "Не выбран тип цеха");
            else
            {
                if (_controller.Indusrty.Departaments == null)
                    _controller.Indusrty.Departaments = new List<Department>();

                var newDepartmentController = new CreateDepartmentController(GetTypeDepartmen());
                var formDepartment = new CreateDepartment(newDepartmentController);
                if (formDepartment.ShowDialog() == DialogResult.OK)
                {
                    var newDepartment = newDepartmentController.Department;                 
                    _controller.AddDepartment(newDepartment);                  
                }            
            }
            UpdateForm?.Invoke(this, e);
        }
       
        private void buttonRemoveDepartment_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (listBoxDepartments.Items.Count==0)
                errorProvider1.SetError(listBoxDepartments, "Список цехов пуст");
            else
            {
                _controller.RemoveDepartment(listBoxDepartments.SelectedIndex);
                listBoxDepartments.Items.RemoveAt(listBoxDepartments.SelectedIndex);
                UpdateForm?.Invoke(this, e);
            }
        }       

        private void buttonMakeIndustry_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBoxNameIndustry.Text))
                errorProvider1.SetError(textBoxNameIndustry, "Не указано имя");
            else if (listBoxDepartments.Items.Count==0)
                errorProvider1.SetError(listBoxDepartments, "Список цехов пуст");
            else
            {
                _controller.Indusrty.NameIndusry = textBoxNameIndustry.Text;
            }
               
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBoxNameIndustry.Text) || listBoxDepartments.Items.Count == 0)
                errorProvider1.SetError(textBoxNameIndustry, "Производство не создано");
            else
            {
                var newReportController = new CreateReportController(_controller.Report);
                var formInfo = new Info(newReportController);
                formInfo.ShowDialog();
            }
        }
    }
}
