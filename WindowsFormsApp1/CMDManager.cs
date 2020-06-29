using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class CMDManager
    {
        public static CMDManager Instance;

        public CMDManager()
        {
            Instance = this;
        }
        public string SetCommandLine(string command,bool CheckMsgBox = false)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            info.FileName = "cmd.exe";

            info.CreateNoWindow = false;
            info.UseShellExecute = false;

            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.RedirectStandardInput = true;

            process.StartInfo = info;
            process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.Close();

            string[] split = { command };
            string result = process.StandardOutput.ReadToEnd();
            string[] reulsts = result.Split(split, StringSplitOptions.None);

            if (CheckMsgBox)
                MessageBox.Show(result);

            process.Close();

            return result;
        }

        public string GetFilePath(OpenFileDialog openFileDialog)
        {
            string path = string.Empty;
            openFileDialog.InitialDirectory = "C:\\";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                if(!path.Contains("apk"))
                {
                    MessageBox.Show("APK파일이 아닌것 같은데요..", "저기요!!");
                    return "apk파일을 넣어주세요!!";
                }
            }

            return path;
        }
    }
}
