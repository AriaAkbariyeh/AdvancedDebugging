using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceIssues
{
    class Consumer
    {

        static void Main(string[] args)
        {
            MOOM moom = new MOOM();
            moom.Run();
        }
    }
}
