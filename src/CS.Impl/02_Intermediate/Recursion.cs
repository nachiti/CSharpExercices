using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {

            List<int> res = new List<int>();
            if (n == 1)
            {

                res.Add(n);
                return res;
            }
            else
            {
                foreach (var v in GetNaturalNumbers(n - 1))
                {
                    res.Add(v);
                }
                res.Add(n);


            }
            return res;



        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            throw new NotImplementedException();
        }

        public int SumNaturalNumbers(int n)
        {

            if (n != 0)
                return n + SumNaturalNumbers(n - 1);
            else
                return n;

        }

        private int ComputeSum(int min, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, 2);

        }

        private bool IsPrime(int n, int current)
        {
            if( n<= 2)
            {
                return (n == 2) ? true : false;

            }
            if (n % current == 0)
                return false;
            if (current * current > n)
                return true;

            return IsPrime(n,current +1);
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }

            return text.Substring(0, 1).Equals(text.Substring(text.Length - 1, 1))
               && IsPalindrome(text.Substring(1, text.Length - 2));

        }
    }
}
    

