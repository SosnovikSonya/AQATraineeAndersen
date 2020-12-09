using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.Task2.Task2_WithAbstractClass
{
    public abstract class BrowserTypeChecker
    {
        public abstract bool CheckBrowser(BrowserType type);
        public abstract BrowserType GetBrowser();
    }
}
