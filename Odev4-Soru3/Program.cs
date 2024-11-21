// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System;

namespace odev
{
    class metod
    {

        public static int CalculateSum(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
        }

        public static double CalculateSum(double x, double y)
        {

            double sum;
            sum = x + y;
            return sum;
        }
        public static int CalculateSum(int x, int y, int z)
        {

            int sum;
            sum = x + y + z;
            return sum;
        }
        

        static void Main()
        {

            Console.WriteLine(metod.CalculateSum(1, 2));
            Console.WriteLine(metod.CalculateSum(1.2, 1.5));
            Console.WriteLine(metod.CalculateSum(1,2,3));



        }
    
    
    
    
    } 

    
}
