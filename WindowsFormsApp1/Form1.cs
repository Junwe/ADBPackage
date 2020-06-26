﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CMDManager cmdmanager = new CMDManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_device_reg(object sender, EventArgs e)
        {
            cmdmanager.SetCommandLine("adb devices");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_device_list(object sender, EventArgs e)
        {
            tb_device_list.Text = cmdmanager.SetCommandLine("adb devices");

            
        }

        private void btn_install_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_Apk_Path_Click(object sender, EventArgs e)
        {
            tb_apk_path.Text = cmdmanager.GetFilePath(ApkFileDialog);
        }
    }
}
