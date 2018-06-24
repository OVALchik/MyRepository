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
           
            //_controller.PropertyChanged += _controller_PropertyChanged;
            UpdateForm += OnUpdateForm;
        }

        private void ShowTypeDepartment()
        {           
            if (_controller.Departament is StorageDepartment)
            {
                textBoxtypeDepartment.Text = "Заготовительный цех";
            }
            if (_controller.Departament is ProcessingDepartment)
            {
                textBoxtypeDepartment.Text = "Обрабатывающий цех";
            }
            if (_controller.Departament is AssemblyDepartment)
            {
                textBoxtypeDepartment.Text = "Сборочно-монтажный цех";
            }
        }   

        private void OnUpdateForm(object sender, EventArgs e)
        {
            textBoxNameDepartment.Text = _controller.NameDepartment;
            ShowPiples();
            ShowProductions();
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
        {/*
            listBoxProduction.Items.Clear();
            foreach (var production in _controller.Productions)
            {
                listBoxPiple.Items.Add(production.NameProduction);
            }*/
        }

        private void buttonChangeListPiple_Click(object sender, EventArgs e)
        {
            var newCreatePipleController= new CreatePipleListController(_controller.PipleList);
            CreatePipleList formPipleList = new CreatePipleList(newCreatePipleController);
            if (formPipleList.ShowDialog() == DialogResult.OK)
            {
                var newPipleList= newCreatePipleController.PipleList;
                _controller.PipleList = newPipleList;
                //_controller.AddPiple(newPipleList);
                foreach (var piple in newPipleList)
                {
                    listBoxPiple.Items.Add(piple);                   
                }                
            }
            UpdateForm?.Invoke(this, e);
        }

        private void buttonChangeProduction_Click(object sender, EventArgs e)
        {
           var newCreateProductionController = new CreateProductionController(_controller.Departament);
            CreateProduction formProduction = new CreateProduction(newCreateProductionController);
            if (formProduction.ShowDialog() == DialogResult.OK)
            {/*
                var newProductionList = CreateProductionController.ProductList;
                foreach (var production in newProductionList)
                {
                    listBoxPiple.Items.Add(production);
                }*/
            }
            UpdateForm?.Invoke(this, e);
        }

        private void buttonMakeDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Fill in all fields");
            }           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxRobot.Text != null && textBoxCountRobot.Text != null)
            {
                _controller.Robot.Add(new RobotMachine(textBoxNameDepartment.Text, Convert.ToInt32(textBoxCountRobot.Text)));
                listBoxRobot.Items.Add(textBoxRobot.Text);
                textBoxRobot.Clear();
                textBoxCountRobot.Clear();
            }
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            _controller.InitializeRobot();
            UpdateForm?.Invoke(this, e);
        }
    }
}
