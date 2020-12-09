using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.Task2.Task2_WithInterface
{
    public class ChromeBrowserTypeChecker : IBrowserTypeChecker
    {
        public bool CheckBrowser(BrowserType type)
        {
            if (type == GetBrowser())
                return true;
            else return false;
        }

        public BrowserType GetBrowser()
        {
            return BrowserType.Chrome;
        }
    }
}
