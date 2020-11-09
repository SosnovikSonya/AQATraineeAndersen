using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.Task2.Task2_WithAbstractClass
{
    public class FirefoxBrowserTypeChecker : BrowserTypeChecker
    {
        public override bool CheckBrowser(BrowserType type)
        {
            if (type == GetBrowser())
                return true;
            else return false;
        }

        public override BrowserType GetBrowser()
        {
            return BrowserType.Firefox;
        }
    }
}
