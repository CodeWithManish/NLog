using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject
{
    public class Example
    {
        Nlog nlog = new Nlog();
        public void Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogInfo("Sum()");
                nlog.LogDebug("Debug Method sum()");
                nlog.LogError("Error occurred in some method");

            }
            int c = a + b;
            nlog.LogInfo("Sum()");
            nlog.LogDebug("Debug Method sum()");
            
        }
    }
}
