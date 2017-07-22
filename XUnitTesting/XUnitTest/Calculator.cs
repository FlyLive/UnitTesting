using System;

namespace XUnitTest
{
    public class Calculator
    {
        public int Multi(int x, int y)
        {
            return x + y;
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
