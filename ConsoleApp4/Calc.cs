﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class Calc
    {
        public static double Add(double a, double b) { return a + b; }

        public static double Sub(double a, double b) { return a - b; }

        public static double Mul(double a, double b) { return a * b; }

        public static double Div(double a, double b) { return a / b; }

        public static double Avg(IEnumerable<int> values)
        {
            return 0;
        }
    }
}
