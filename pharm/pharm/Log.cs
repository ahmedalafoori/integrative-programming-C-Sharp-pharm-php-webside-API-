using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharm
{
    public  class Log
    {
        private static Log obj;
        private Log() { }
        public static Log GetInstance()
        {
            
                if (obj == null)
                    obj = new Log();
                return obj;
            
        }
        public void LoggingDetails(string FileName, string Operation)
        {
            File.AppendAllText("D:\\"+ FileName, String.Format("\n The person :{0} has logged at : {1} and did the operation : {2}", UserInfo.userEmail, DateTime.Now.ToString(), Operation));
        }
    }
}
