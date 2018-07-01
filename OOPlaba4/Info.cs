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
    public partial class Info : Form
    {
        private readonly CreateReportController _controller;
            
        public void ShowInfo()
        {
            richTextBoxInfo.Clear();
            richTextBoxInfo.Text = _controller.Info.ToString();
        }

        public Info(CreateReportController controller)
        {
            InitializeComponent();
            _controller = controller;
            ShowInfo();         
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
