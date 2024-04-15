using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft050_Project_Attempt_2
{
    public class Logging
    {
        public static string strLogFilePath = Path.Combine(Path.GetTempPath(), "GoHomeDebugFile.log");
        public static void VerifyLogFile()
        {
            if (!File.Exists(strLogFilePath))
            {
                using (StreamWriter swVerifyLogFile = File.CreateText(strLogFilePath))
                {
                    swVerifyLogFile.WriteLine($"{DateTime.Now} - Log file created");
                }
            }
            else
            {
                DebugLog("Debug log found");
            }
        }

        public static void DebugLog(string strDebugInput)
        {
            using (StreamWriter swDebugLog = File.AppendText(strLogFilePath))
            {
                swDebugLog.WriteLine($"{DateTime.Now} - {strDebugInput}");
            }
        }

        public static void OpenLog()
        {
            Process.Start(new ProcessStartInfo(strLogFilePath) { UseShellExecute = true });
        }
    }
}
