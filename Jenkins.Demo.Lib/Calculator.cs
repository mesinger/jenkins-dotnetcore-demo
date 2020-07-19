using System;

namespace Jenkins.Demo.Lib
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;

        public int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Denominator may not be 0");
            }
            
            return a / b;
        }
    }
}