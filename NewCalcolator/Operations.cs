using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalcolator
{
    public class Operations
    {
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Addition(int[] arr)
        {

            return arr.Sum();
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Subtract(int[] arr)
        {
            double num = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                num -= arr[i];
            }
            return num;

        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static decimal? Divide(int num1, int num2)
        {
             int result = 0;
             try
             {
                 result = num1 / num2;
                Console.WriteLine();
                return result;
             }
             catch (DivideByZeroException )
             {
                string msg = "Can not be divided";
                Console.WriteLine("Can not be divided" , msg.Contains(""));
                return null;

             }
             
           /* if (num2 == 0)
                throw new ArithmeticException("Divide By Zero error");
            return num1 / num2;*/
        }

    }
}
