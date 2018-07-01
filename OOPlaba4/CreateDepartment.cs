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
    public partial class CreateDepartment : Form
    {
        private readonly CreateDepartmentController _controller;
        public event EventHandler UpdateForm;

        public CreateDepartment(CreateDepartmentController controller)
        {
            InitializeComponent();
            _controller = controller;

            ShowTypeDepartment();
            panelRobot.Visible = _controller.VisibleRobotCreate;
           
            UpdateForm += OnUpdateForm;
        }
       
        private void ShowTypeDepartment()
        {
            if (_controller.TypeDepartament == TypeDepartment.StorageDepartment)
            {
                textBoxtypeDepartment.Text = "Заготовительный цех";
            }
            if (_controller.TypeDepartament == TypeDepartment.ProcessingDepartment)
            {
                textBoxtypeDepartment.Text = "Обрабатывающий цех";
            }
            if (_controller.TypeDepartament == TypeDepartment.AssemblyDepartment)
            {
                textBoxtypeDepartment.Text = "Сборочно-монтажный цех";
            }
        }

       
        private void OnUpdateForm(object sender, EventArgs e)
        {           
            ShowPiples();
            ShowProductions();
            if(_controller.TypeDepartament == TypeDepartment.StorageDepartment)
                ShowRobot();
        }

        private void ShowPiples()
        {
            if (_controller.PipleList != null)
            {
                listBoxPiple.Items.Clear();
                foreach (var piple in _controller.PipleList)
                {
                    listBoxPiple.Items.Add(piple);
                }
            }                     
        }

        private void ShowRobot()
        {
            if (_controller.Robot != null)
            {
                listBoxRobot.Items.Clear();
                foreach (var robot in _controller.Robot)
                {
                    listBoxRobot.Items.Add(robot.NameMachine);
                }
            }
        }
        private void ShowProductions()
        {
            if (_controller.ProductionList!= null)
            {
                listBoxProduction.Items.Clear();
                foreach (var product in _controller.ProductionList)
                {
                    listBoxProduction.Items.Add(product.NameProduction);
                }
            }
        }

        private void buttonChangeListPiple_Click(object sender, EventArgs e)
        {
            if (_controller.PipleList == null)
                _controller.PipleList = new List<string>();

            var newCreatePipleController= new CreatePipleListController(_controller.PipleList);
            CreatePipleList formPipleList = new CreatePipleList(newCreatePipleController);
            if (formPipleList.ShowDialog() == DialogResult.OK)
            {
                var newPipleList= newCreatePipleController.PipleList;
                _controller.PipleList = newPipleList;               
                foreach (var piple in newPipleList)
                {
                    listBoxPiple.Items.Add(piple);                   
                }                
            }
            UpdateForm?.Invoke(this, e);
        }

        private void buttonChangeProduction_Click(object sender, EventArgs e)
        {
            if (_controller.ProductionList == null)
                _controller.ProductionList = new List<Production>();
            var newCreateProductionController = new CreateProductionController(_controller.ProductionList);
            CreateProduction formProductionList = new CreateProduction(newCreateProductionController);
            if (formProductionList.ShowDialog() == DialogResult.OK)
            {
                var newProductionList = newCreateProductionController.ProductionList;
                _controller.ProductionList = newProductionList;            
                foreach (var product in newProductionList)
                {
                    listBoxProduction.Items.Add(product);
                }
            }
            UpdateForm?.Invoke(this, e);
        }

        private void buttonMakeDepartment_Click(object sender, EventArgs e)
        {
           errorProvider1.Clear();
           if (textBoxNameDepartment.Text=="")
              errorProvider1.SetError(textBoxNameDepartment, "Не указано имя");
           else if(listBoxPiple.Items.Count==0)
              errorProvider1.SetError(listBoxPiple, "Создайте список сотрудников");
           else if(listBoxProduction.Items.Count == 0)
              errorProvider1.SetError(listBoxProduction, "Создайте список продукции");
           else if(listBoxRobot.Items.Count == 0 && _controller.TypeDepartament == TypeDepartment.StorageDepartment)
              errorProvider1.SetError(listBoxRobot, "Создайте список систем");
           else
            {
                try
                {
                    _controller.NameDepartment = textBoxNameDepartment.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Fill in all fields");
                }
            }
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           int numberInt = 0;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(textBoxRobot.Text) && !Int32.TryParse(textBoxCountRobot.Text, out numberInt))
                errorProvider1.SetError(textBoxCountRobot, "Неверно введены данные");
            else
            {
                if (_controller.Robot == null)
                    _controller.Robot = new List<RobotMachine>();

                _controller.Robot.Add(new RobotMachine(textBoxNameDepartment.Text, Convert.ToInt32(textBoxCountRobot.Text)));
                listBoxRobot.Items.Add(textBoxRobot.Text);
                textBoxRobot.Clear();
                textBoxCountRobot.Clear();
            }
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            if (_controller.TypeDepartament == TypeDepartment.StorageDepartment)
                _controller.InitializeRobot();

            _controller.InitializeProductions();
            _controller.InitializePiples();
            UpdateForm?.Invoke(this, e);
        }        
    }
}
