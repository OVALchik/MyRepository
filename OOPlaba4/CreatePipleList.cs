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
            ShowPipleList();
            UpdateForm += OnUpdateForm;
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
                listBoxPiple.Items.Clear();
                foreach (var fio in _controller.PipleList)
                    listBoxPiple.Items.Add(fio);
            }
            
        }
        
        private void buttonAddPiple_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (string.IsNullOrEmpty(textBoxFIO.Text))
                errorProvider2.SetError(textBoxFIO, "Не указано имя");
            else
            {
                listBoxPiple.Items.Add(textBoxFIO.Text);
                _controller.AddPiple(textBoxFIO.Text);
            }        
            UpdateForm?.Invoke(this, e);                        
        }           

        private void buttonRemovePiple_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (listBoxPiple.Items.Count == 0)
                errorProvider2.SetError(listBoxPiple, "Список пуст");
            else
            {
                _controller.RemovePiple(listBoxPiple.SelectedIndex);
                listBoxPiple.Items.RemoveAt(listBoxPiple.SelectedIndex);
                UpdateForm?.Invoke(this, e);
            }
        }


        private void buttonMakePipleList_Click(object sender, EventArgs e)
        {          
            DialogResult = DialogResult.OK;
            Close();           
        }       
        
        private void listBoxPiple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPiple.SelectedItem != null)
            {
                textBoxFIO.Text = listBoxPiple.SelectedItem.ToString();
            }                
        }
       
    }
}
