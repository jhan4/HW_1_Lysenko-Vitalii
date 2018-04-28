using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ScientificCalculator : SimpleCalculator
    {
        public int ArrayMaxValue(int[] arr)
        {
            return arr.Max();
        }
        public int ArrayMinValue(int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (result > arr[i])
                { result = arr[i]; }
            return result;
        }
        public bool Compare(int x, int y)
        {
            bool result = true;
            if (x > y)
            { result = true; }

            if (x < y)
            { result = true; }

            if (x == y)
            { result = true; }
            return result;
        }
        public double Sqrt(double num)
        {return Math.Sqrt(num);}

        public double Pow(double num, double n)
        {
            double num_n = 1;
            for (int i = 0; i < n; i++)
            {
                num_n = Multiplication(num_n, num);
            }
            return num_n;
        }

        public int Mod(int x, int y) 
        {
            
            return x % y;
        }

        public double Percent(double x, double y)
        {
            return Divide((Multiplication(x, y)), 100);
        }

        public double Logarithm(double number_log, double base_log)
        {
            return Math.Log(number_log, base_log);
        }

        public double Decimal_Logarithm(double number)
        {
            return Math.Log10(number);
        }

    }
}
