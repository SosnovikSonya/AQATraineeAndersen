using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.Task2.Task2_WithInterface
{
    public interface IBrowserTypeChecker
    {
        bool CheckBrowser(BrowserType type);
        BrowserType GetBrowser();
    }
}
