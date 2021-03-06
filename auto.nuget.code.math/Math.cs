﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace auto.nuget.code.utilities
{
    public static class Math
    {
        //version 1.0 baisc int math operations.
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }

            return x / y;
        }
    }
}
