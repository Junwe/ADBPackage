using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ADBPackage
    {

        public string GetDeviceList()
        {
            string result = CMDManager.Instance.SetCommandLine("adb devices");
            string[] split = { "List of devices attached" };
            string[] device_list = result.Split(split, StringSplitOptions.None);
            string devices = string.Empty;


            return result;
        }

        public void RegDevice(string deviceip)
        {
            string port = "5555";
            CMDManager.Instance.SetCommandLine("adb kill-server");
            CMDManager.Instance.SetCommandLine("adb wait-for-device");
            CMDManager.Instance.SetCommandLine("adb tcpip " + port);

            CMDManager.Instance.SetCommandLine("adb connect " + deviceip + " " + port);
            CMDManager.Instance.SetCommandLine("timeout /t 1");
        }
    }
}
