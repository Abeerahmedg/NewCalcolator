using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalcolator
{
    public class Operations
    {
       public static double Addition(double num1 , double num2)
        {
            return num1 + num2;
        }
        public static double Addition(int[] arr)
        {
            double sum = arr[0];
            return sum ;
        }
       public static double Substract(double num1 , double num2)
        {
            return num1 - num2;
        }
        public static double Substract(int[] arr)
        {
            double sum =arr[0];
            return sum;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1 ,double num2)
        {
            return num1 / num2;
        }
    }
  
}
