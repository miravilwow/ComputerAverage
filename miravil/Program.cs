using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miravil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalgrades = 5;
            int sum = 0;

            for( int i = 0; i < totalgrades; i++ ) { 
                Console.WriteLine("Enter 5 grades seperated by new line: ", i + 1);
                int grades = Convert.ToInt32(Console.ReadLine());

                sum += grades;
            }
            double result = (double)sum / totalgrades;
            double average = Math.Round(result);
            Console.WriteLine("The average is " + result + " and round off to " + average);
        }
    }
}
