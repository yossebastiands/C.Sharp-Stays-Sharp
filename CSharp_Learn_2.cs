using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// This is a short program about displaying a formatted string output.
namespace Staysharp
{
    class CSharp_Learn_2
    {
        static void Main(string[] args)
        {
            /// Displaying a formatted string
            int x = 10;
            double y = 20;
            Console.WriteLine("x = {0}; y = {1}", x, y);
            /// The value of x replaced {0} and the value of y replaced {1}.
            /// You can have as many variable placeholders as you need. (i.e.: {3}, {4}, etc.).
        }
    }
}
