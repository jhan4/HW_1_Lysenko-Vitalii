using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class ScientificCalculator
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
        public bool compare(int x, int y)
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
        public static double Sqrt(double num)
        { return Math.Sqrt(num); }

        public static double Pow(double x, double y)
        { return Math.Pow(x, y); }

        public int Mod(int x, int y)
        { return x % y; }

        public static double Percent(double x, double y)
        {
            return (x / 100) * y;
        }
    }
}
