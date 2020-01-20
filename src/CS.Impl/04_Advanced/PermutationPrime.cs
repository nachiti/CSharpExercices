using System;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        
        public int[] GetPermutationPrimes(int upperBound)
        {
            int[] T = new int[upperBound];
         /*   if (IsPrime(upperBound)==true)
            
                return t;
            */
            int v = 1,i=0;
            while( v < upperBound)
            {
                if (IsPrime(v))
                {
                    T[i] = v;
                    i++;
                    i++;
                }
                v++;
         
            }
            return T;
   
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, 2);

        }

        private bool IsPrime(int n, int current)
        {
            if (n <= 2)
            {
                return (n == 2) ? true : false;
              
            }
            if (n % current == 0)
                return false;
            if (current * current > n)
            {
      
                return true;     
            }             
            return IsPrime(n, current + 1);
        }
    }
}
