/// Still with user input but we use convert.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staysharp
{
    class CSharp_Learn_4
    {
        static void Main(string[] args)
        {
            /// The Console.ReadLine() method returns a string value.
            /// If you are expecting another type of value (such as int or double), the entered data must be converted to that type.
            /// This can be done using the Convert.ToXXX methods, where XXX is the .NET name of the type that we want to convert to.
            /// Example : Convert.ToDouble, Convert.ToBoolean
            /// Three convertions in integer (in size of bits)
            /// Convert.ToInt16
            /// Convert.ToInt32
            /// Convert.ToInt64
            /// The default int type in C# is 32-bit.
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);

            double n;
            string x = "77";
            n = Convert.ToDouble(x);
        }
    }
}