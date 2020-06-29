namespace WindowsFormsApp1.form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_port_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(12, 36);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(339, 21);
            this.tb_port.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "포트 입력";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_port_ok
            // 
            this.btn_port_ok.Location = new System.Drawing.Point(131, 137);
            this.btn_port_ok.Name = "btn_port_ok";
            this.btn_port_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_port_ok.TabIndex = 2;
            this.btn_port_ok.Text = "확인";
            this.btn_port_ok.UseVisualStyleBackColor = true;
            this.btn_port_ok.Click += new System.EventHandler(this.btn_port_ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 172);
            this.Controls.Add(this.btn_port_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_port);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_port_ok;
    }
}