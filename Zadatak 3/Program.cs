using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger consoleLogger = new ConsoleLogger();
            Logger fileLogger = new FileLogger("SystemDataProviderLog.txt");

            SimpleSystemDataProvider dataProvider = new SystemDataProvider();

            while (true)
            {
                consoleLogger.Log(dataProvider);
                fileLogger.Log(dataProvider);
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
