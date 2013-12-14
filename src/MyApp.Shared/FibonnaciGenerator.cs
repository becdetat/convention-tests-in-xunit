using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public static class FibonnaciGenerator
    {
        public static int For(int i)
        {
            if (i < 3) 
                return 1;
            if (i < 5)
                return i - 1;
            if (i == 5)
                return i;
            return For(i - 1) + For(i - 2);
        }
    }
}
