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
    public partial class CreatePipleList : Form
    {
        private readonly CreatePipleListController _controller;
        public event EventHandler UpdateForm;

        public CreatePipleList(CreatePipleListController controller)
        {
            InitializeComponent();
            _controller = controller;
                   
            UpdateForm += OnUpdateForm;
            //_controller.PropertyChanged += _controller_PropertyChanged;
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {          
            ShowPipleList();
            EnableRemovePipleButton();
            textBoxFIO.Clear();
            textBoxFIO.Clear();
            listBoxPiple.SelectedItem = null;
        }

        private void EnableRemovePipleButton()
        {
            buttonRemovePiple.Enabled = _controller.CanRemovePiple;
        }       

        public void ShowPipleList()
        {
            if (_controller.PipleList != null)
            {
                foreach (var fio in _controller.PipleList)
                    listBoxPiple.Items.Add(fio);
            }
            
        }
        
        private void buttonAddPiple_Click(object sender, EventArgs e)
        {
            listBoxPiple.Items.Add(textBoxFIO.Text);
            _controller.AddPiple(textBoxFIO.Text);
            UpdateForm?.Invoke(this, e);
            // textBoxFIO.Clear();                         
        }           

        private void buttonRemovePiple_Click(object sender, EventArgs e)
        {            
            //textBoxFIO.Clear();
            _controller.RemovePiple(listBoxPiple.SelectedIndex);            
            listBoxPiple.Items.RemoveAt(listBoxPiple.SelectedIndex);
            //listBoxPiple.SelectedItem = null;
            UpdateForm?.Invoke(this, e);
        }


        private void buttonMakePipleList_Click(object sender, EventArgs e)
        {
            //_controller.FIO = _newPipleList.FIO;
            DialogResult = DialogResult.OK;
            Close();           
        }       
        /*
        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.CanSave))
                buttonMakePipleList.Enabled = _controller.CanSave;           

           

            if (e.PropertyName == nameof(_controller.CanRemovePiple))
                buttonRemovePiple.Enabled = _controller.CanRemovePiple;
        }
        */
        private void listBoxPiple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPiple.SelectedItem != null)
            {
                textBoxFIO.Text = listBoxPiple.SelectedItem.ToString();
            }                
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            listBoxPiple.SelectedItem = textBoxFIO.Text;
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            _controller.InitializeIndustry();
            UpdateForm?.Invoke(this, e);
        }
    }
}
