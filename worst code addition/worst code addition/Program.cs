using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worst_code_addition
{
    class Program
    {
        static void Main(string[] args) {Console.Write("Please write an integer."); Console.WriteLine(); string stringNumber1 = Console.ReadLine(); int number1 = Convert.ToInt32(stringNumber1); Console.Write("Please write another integer."); Console.WriteLine(); string stringNumber2 = Console.ReadLine(); int number2 = Convert.ToInt32(stringNumber2); int result; if (number1 < number2 || number1 > number2) result = number1 + number2; else result = (number1 + number2) * 3; Console.Write(number1 + " " + "+" + " " + number2 + " " + "=" + " " + result); Console.ReadLine();}
    }
}
