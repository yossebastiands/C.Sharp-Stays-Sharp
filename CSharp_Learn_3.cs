/// This is about user-input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staysharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            /// You can also prompt the user to enter data and then use the Console.ReadLine method 
            /// to assign the input to a string variable.
            /// The Console.ReadLine method waits for user input and then assigns it to the variable. 
            yourName = Console.ReadLine();
            /// Note the empty parentheses in the ReadLine method. This means that it does not take any arguments.
          
            Console.WriteLine("Hello {0}", yourName);
        }
    }
}