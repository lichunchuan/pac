using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCoverage
{
   public class Math
    {
        public int Divide(int x,int y)
        {
            if (y == 0)
            
                throw new System.ArgumentException("Denominator can not be zero");
            
            else
            
                return x / y;
            
        }
        public int Multiple(int x, int y)
        {
            return x * y;
        }
    }
}
