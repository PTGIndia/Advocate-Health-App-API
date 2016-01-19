using System;
using System.IO;

namespace HCP.WebAPI.Helper
{
    public class LogEntry
    {        
        public void WriteErrorLog(string Message)
        {
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\ErrorLogsFile.txt", true))
            {                
                sw.WriteLine(DateTime.Now.ToString() + " : " + Message);
            }
        }        
    }
}