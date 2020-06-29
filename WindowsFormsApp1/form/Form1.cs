using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.form;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CMDManager _cmdmanager = new CMDManager();
        ADBPackage _adbPackage = new ADBPackage();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_device_reg(object sender, EventArgs e)
        {
            Form2 inputPortPopUp = new Form2(_adbPackage.RegDevice);
            inputPortPopUp.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_device_list(object sender, EventArgs e)
        {
            tb_device_list.Text = CMDManager.Instance.SetCommandLine("adb devices");


        }

        private void btn_install_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_Apk_Path_Click(object sender, EventArgs e)
        {
            tb_apk_path.Text = _cmdmanager.GetFilePath(ApkFileDialog);
        }
    }
}
