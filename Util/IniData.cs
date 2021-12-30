using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace iotApp1005.Util
{
    class IniData
    {
#pragma warning disable S2223 // Non-constant static fields should not be visible
        public static string INI_FILE_NAME = @"\setting.ini";
        public static string SECTION = "serial";
        public static string KEY_PORT = "port";
        public static string KEY_BAUDRATE = "baudrate";
        public static string KEY_DATABITS = "databits";
        public static string KEY_PARITY = "parity";
        public static string KEY_STOPBITS = "stopbits";

        public static string DEFAULT_PORT = "COM3";
        public static string DEFAULT_BAUDRATE = "9600";
        public static string DEFAULT_DATABITS = "8";
        public static string DEFAULT_PARITY = "None";
        public static string DEFAULT_STOPBITS = "1";

        readonly  string iniPath;

        public IniData(string iniPath)
        {
            this.iniPath = iniPath;
        }

        // win32 API ini 파일 읽기
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string section, string key,
            string def, StringBuilder retVal,
            int size, string filePath);

        // win32 API ini 파일 쓰기
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(
            string section, string key,
            string val, string filePath);

        public string getIniVal(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, "",
                temp, 255, iniPath);
            return temp.ToString();
        }

        public void setIniVal(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
