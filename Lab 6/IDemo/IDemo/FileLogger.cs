using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemo
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var file = new System.IO.StreamWriter(@".\log.txt", true))
            {
                file.WriteLine(message);
            }
        }
    }
}
