using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOfSumOfSquareAndSquareOfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double difference=0, sumOfSquare=0, squareOfSum=0, temp=0;
            for (double i = 1; i <= 100; i++)
            {
                sumOfSquare = sumOfSquare + i*i;
                temp = temp + i;
            }
            squareOfSum = temp*temp;
            difference = squareOfSum - sumOfSquare;
            Console.WriteLine(" Differenc is: " + difference);
            Console.ReadKey();
        }
    }
}
