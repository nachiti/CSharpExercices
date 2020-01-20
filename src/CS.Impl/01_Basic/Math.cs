﻿using System;
using System.Collections.Generic;

namespace CS.Impl._01_Basic
{
    public class Math
    {
        public int Sum(int a, int b)
        {
            return a+b;
        }

        public int Divide(int a, int b)
        {
          return a/b;
        }

        public int SumTable(IEnumerable<int> integersTable)
        {
            int res = 0;
            foreach (var v in integersTable) {
                res += v;
            };
            return res;
        }
    }
}

