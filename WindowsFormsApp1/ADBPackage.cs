using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ADBPackage
    {
        public string[] GetDeviceList(string result)
        {
            string[] split = { "List of devices attached" };
            string[] device_list = result.Split(split, StringSplitOptions.None);



            return device_list;
        }
    }
}
