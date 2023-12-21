using System;

namespace DelegateBasics
{

    delegate bool LoggerDelegate    (string pAnyIssue, DateTime pDateTime);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
               A delegate can reference static methods
             */
            LoggerDelegate lLogger = new LoggerDelegate(FileLogger);
            //lLogger("Screen logger starting ", DateTime.Now);

           
            
            /*
             A delegate can reference instance methods

             */

            Log lLog = new Log();

            LoggerDelegate lLoggerOnInstance = new LoggerDelegate(lLog.ScreenLogger);
            //lLoggerOnInstance("Screen logger on instance method", DateTime.Now);

            /*
             Podemos crear un delegado multicast, que hace referencia a dos 
            delegados
             */



            LoggerDelegate lMulticastDelegate = lLoggerOnInstance + lLogger;
            //lMulticastDelegate("Soy multicast", DateTime.Now);


            /*
             Tambien podemos pasar como parametro al delegado
             */

            LogMonitor(lMulticastDelegate, "Realizando multicast");

        }


        /// <summary>
        /// Este es un metodo que recibe como parametro un delegado
        /// </summary>
        /// <param name="pLoggerDelegate"></param>
        /// <param name="pMessage"></param>
        static void LogMonitor(LoggerDelegate pLoggerDelegate, string pMessage)
        { 
            pLoggerDelegate(pMessage, DateTime.Now);
        }


        static bool ScreenLogger(string pAnyIssue, DateTime pDateTime)
        {
            Console.WriteLine($"{pDateTime} This is happening: {pAnyIssue}");
            return true;
        }

        static bool FileLogger(string pAnyIssue, DateTime pDateTime)
        {

            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log.txt"), true))
            {
                sw.WriteLine($"{pDateTime} This is happening: {pAnyIssue}");
            };

            return true;   
        }
    }
}
