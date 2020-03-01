using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_in_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            string line; 
            Console.WriteLine("Enter one or more lines of text (press CTRL+Z to exit the input):");
            Console.WriteLine("Then press enter to show reverse stack");

            do 
            {
                line = Console.ReadLine();
                if (line != null)
                {
                    myStack.Push(line);
                }
            } while (line != null);

            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop());

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
