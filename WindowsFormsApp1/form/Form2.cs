using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.form
{
    public partial class Form2 : Form
    {
        Action<string> _portAction;
        public Form2(Action<string> portAction)
        {
            InitializeComponent();
            _portAction = portAction;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_port_ok_Click(object sender, EventArgs e)
        {
            _portAction(tb_port.Text);
            Close();
        }
    }
}
