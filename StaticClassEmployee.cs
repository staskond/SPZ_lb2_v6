using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh_lb2_v6
{
    public static class StaticClassEmployee
    {
        public static string FullName { set; get; }
        public static decimal Salary { set; get; }
        public static void NulableAllValue()
        {
            FullName = null;
            Salary = 0;
        }
    }
}
