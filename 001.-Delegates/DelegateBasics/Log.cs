using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasics
{
    internal class Log
    {
        public bool ScreenLogger(string pAnyIssue, DateTime pDateTime)
        {
            Console.WriteLine($"{pDateTime} This is happening: {pAnyIssue}");
            return true;
        }

        public bool FileLogger(string pAnyIssue, DateTime pDateTime)
        {

            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt")))
            {
                sw.WriteLine($"{pDateTime} This is happening: {pAnyIssue}");
            };

            return true;
        }
    }
}
