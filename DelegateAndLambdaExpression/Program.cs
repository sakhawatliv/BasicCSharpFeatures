using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndLambdaExpression
{
    class Program
    {
        delegate int CalculationHamdaler(int anyNumber, int anotherNumber);
        static void Main(string[] args)
        {


//            CalculationHamdaler calculationHamdaler = delegate(int firstNumber, int secondNumber)
//                                                                      {
//                                                                          return firstNumber + secondNumber;
//                                                                      };
//
//
//
//            int result = calculationHamdaler(5, 6);
//            Console.WriteLine(result);
//            Console.ReadKey();





            //a shortcut approach

//            CalculationHamdaler calculationHamdaler = (int firstNumber, int secondNumber) => firstNumber + secondNumber;
//            int result = calculationHamdaler(5, 6);
//            Console.WriteLine(result);
//            Console.ReadKey();



            //Note: this is a lambda expression. the right part of a lambda sign is paramer list and right side is a 
            //expressin or methodbody.



            //a more shortcut approach


            CalculationHamdaler calculationHamdaler = (int X, int Y) => X+Y;
            int result = calculationHamdaler(5, 6);
            Console.WriteLine(result);
            Console.ReadKey();

        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
