namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Deivce_Reg = new System.Windows.Forms.Button();
            this.Btn_device_Check = new System.Windows.Forms.Button();
            this.btn_install = new System.Windows.Forms.Button();
            this.tb_device_list = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_apk_path = new System.Windows.Forms.TextBox();
            this.text_apk_path = new System.Windows.Forms.Label();
            this.ApkFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_Apk_Path = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Deivce_Reg
            // 
            this.btn_Deivce_Reg.Location = new System.Drawing.Point(54, 55);
            this.btn_Deivce_Reg.Name = "btn_Deivce_Reg";
            this.btn_Deivce_Reg.Size = new System.Drawing.Size(110, 49);
            this.btn_Deivce_Reg.TabIndex = 0;
            this.btn_Deivce_Reg.Text = "디바이스 등록";
            this.btn_Deivce_Reg.UseVisualStyleBackColor = true;
            this.btn_Deivce_Reg.Click += new System.EventHandler(this.btn_device_reg);
            // 
            // Btn_device_Check
            // 
            this.Btn_device_Check.Location = new System.Drawing.Point(54, 126);
            this.Btn_device_Check.Name = "Btn_device_Check";
            this.Btn_device_Check.Size = new System.Drawing.Size(110, 51);
            this.Btn_device_Check.TabIndex = 1;
            this.Btn_device_Check.Text = "디바이스 확인";
            this.Btn_device_Check.UseVisualStyleBackColor = true;
            this.Btn_device_Check.Click += new System.EventHandler(this.btn_device_list);
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(54, 204);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(110, 51);
            this.btn_install.TabIndex = 2;
            this.btn_install.Text = "APK설치";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // tb_device_list
            // 
            this.tb_device_list.Location = new System.Drawing.Point(282, 126);
            this.tb_device_list.Multiline = true;
            this.tb_device_list.Name = "tb_device_list";
            this.tb_device_list.Size = new System.Drawing.Size(348, 224);
            this.tb_device_list.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "디바이스 목록";
            // 
            // tb_apk_path
            // 
            this.tb_apk_path.Location = new System.Drawing.Point(282, 55);
            this.tb_apk_path.Name = "tb_apk_path";
            this.tb_apk_path.Size = new System.Drawing.Size(348, 21);
            this.tb_apk_path.TabIndex = 5;
            // 
            // text_apk_path
            // 
            this.text_apk_path.AutoSize = true;
            this.text_apk_path.Location = new System.Drawing.Point(280, 29);
            this.text_apk_path.Name = "text_apk_path";
            this.text_apk_path.Size = new System.Drawing.Size(53, 12);
            this.text_apk_path.TabIndex = 6;
            this.text_apk_path.Text = "APK경로";
            // 
            // ApkFileDialog
            // 
            this.ApkFileDialog.FileName = "openFileDialog1";
            this.ApkFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_Apk_Path
            // 
            this.btn_Apk_Path.Location = new System.Drawing.Point(636, 53);
            this.btn_Apk_Path.Name = "btn_Apk_Path";
            this.btn_Apk_Path.Size = new System.Drawing.Size(75, 23);
            this.btn_Apk_Path.TabIndex = 7;
            this.btn_Apk_Path.Text = "클릭";
            this.btn_Apk_Path.UseVisualStyleBackColor = true;
            this.btn_Apk_Path.Click += new System.EventHandler(this.btn_Apk_Path_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 388);
            this.Controls.Add(this.btn_Apk_Path);
            this.Controls.Add(this.text_apk_path);
            this.Controls.Add(this.tb_apk_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_device_list);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.Btn_device_Check);
            this.Controls.Add(this.btn_Deivce_Reg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Deivce_Reg;
        private System.Windows.Forms.Button Btn_device_Check;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.TextBox tb_device_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_apk_path;
        private System.Windows.Forms.Label text_apk_path;
        private System.Windows.Forms.OpenFileDialog ApkFileDialog;
        private System.Windows.Forms.Button btn_Apk_Path;
    }
}

