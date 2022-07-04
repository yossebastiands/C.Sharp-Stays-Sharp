/* Welcome to first program for independent learning in C#. */

/// C# is an elegant object-oriented language that enables developers 
/// to build a variety of secure and robust applications that run on the .NET Framework.
/// C# applications can run on the NET. Framework

/// NET. Framework
/// The .NET Framework consists of the Common Language Runtime (CLR) and the .NET Framework class library.
/// The CLR is the foundation of the .NET Framework. It manages code at execution time, 
/// providing core services such as memory management, code accuracy, and many other aspects of your code.
/// The class library is a collection of classes, interfaces, and value types that enable you 
/// to accomplish a range of common programming tasks, such as data collection, file access, and working with text.
/// C# programs use the .NET Framework class library extensively to do common tasks and provide various functionalities.

/// Variables
/// Programs typically use data to perform tasks.
/// Creating a variable reserves a memory location, or a space in memory, for storing values. 
/// It is called variable because the information stored in that location can be changed when the program is running.
/// To use a variable, it must first be declared by specifying the name and data type.
/// A variable name, also called an identifier, can contain letters, 
/// numbers and the underscore character (_) and must start with a letter or underscore.
/// Although the name of a variable can be any set of letters and numbers, 
/// the best identifier is descriptive of the data it will contain. 
/// This is very important in order to create clear, understandable and readable code!

/// For example, firstName and lastName are good descriptive variable names, while abc and xyz are not.

/// Variable Types
/// A data type defines the information that can be stored in a variable, 
/// the size of needed memory and the operations that can be performed with the variable.

/// A line of code that completes an action is called a statement. Each statement in C# must end with a semicolon.


/// Built-in Data Types
/* 
There are a number of built-in data types in C#. The most common are:
int - integer.
float - floating point number.
double - double-precision version of float.
char - a single character.
bool - Boolean that can have only one of two values: True or False.
string - a sequence of characters.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn_1
{
    internal class Program
    {

        /// <summary>
        /// Main is the starting point of every application, i.e. the point where our program starts execution from.
        /// Every console application in C# should contian Main method
        /// Console Application uses text-only interface.
        static void Main(string[] args)
        {
            /// Store an integer value (a whole number) in a variable, use the [int] keyword.
            int myAge;
            /// A variable named myAge has been declared with the type of integer. 
            myAge = 22;
            /// Another way to assign value :
            int SelfAge = 22;
            /// Remember that you need to declare the variable before using it.
            /// Example of data-types :
            int x = 69;
            double pi = 3.14;
            char y = 'Z';
            /// Note that char values are assigned using single quotes and string values require double quotes.
            bool isOnline = true;
            string firstName = "Yos";
            /// Most applications require some input from the user and give output as a result.
            /// To display text to the console window you use the Console.Write or Console.WriteLine methods. 
            /// The difference between these two is that Console.WriteLine is followed by a line terminator, 
            /// which moves the cursor to the next line after the text output.
            /// Below is displaying output :
            Console.WriteLine("Hello world, ");
            Console.Write("My name is John");
            Console.WriteLine("My age is : ");
            Console.Write(myAge);
            Console.Write(" years old.");


        }   

    }
}

/// For now this is everything for the first part.