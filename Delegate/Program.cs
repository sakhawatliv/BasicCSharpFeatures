using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate int CalcultionHandaler(int anyNumber, int anOtherNumber);
        static void Main(string[] args)
        {
            CalcultionHandaler calcultionHandaler = Add;
            int result = calcultionHandaler(5, 5);
            Console.WriteLine(result);

            Console.ReadKey();




        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
