using AQATrainee.Task2.Task2_WithAbstractClass;
using AQATrainee.Task2.Task2_WithInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.Task2
{
    class Task2_Main
    {
        static void Main(string[] args)
        {            
            BrowserType type;
            type = BrowserType.Chrome;
            Console.WriteLine(type);

            var IEBrowser = new Task2_WithInterface.InternetExplorerBrowserTypeChecker();
            Console.WriteLine(IEBrowser.CheckBrowser(type));

            var ChromeBrowser = new Task2_WithAbstractClass.ChromeBrowserTypeChecker();
            Console.WriteLine(ChromeBrowser.CheckBrowser(type));

            Console.ReadKey();
        }
    }
}
