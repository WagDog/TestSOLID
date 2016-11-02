using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "";
            string s = "SOLID (Refer to Section 4). SOLID is an acronym for the following:-\n\n";
            s += "S - Single Responsibility Principal\n";
            s += "\tThere should never be more than one reason for a class change.\n";
            s += "\tA class should only have one job to perform.\n";
            s += "\tBy doing the above, classes become smaller, cleaner,\n\tsimpler to understand and maintain.\n";
            s += "\n\nPress any key to continue.....";
            Console.WriteLine(s);
            Console.ReadLine();

            s = "O - Open / Closed Principal\n";
            s += "\tOpen to extension. New functionality or requirements without editing the existing code.\n";
            s += "\tClosed to modification, except for bug corrections.\n";
            s += "\tUse interfaces.\n";
            s += "\n\nPress any key to continue.....";
            Console.WriteLine(s);
            Console.ReadLine();

            s = "L - Liskov Substitution Principal\n";
            s += "\tUse Derived Classes without knowing it.\n";
            s += "\tSubclasses must operate in the same way as their base class.\n";
            s += "\n\nPress any key to continue.....";
            Console.WriteLine(s);
            Console.ReadLine();

            s = "I - Interface Segregation Principal\n";
            s += "\tOpen to extension. New functionality or requirements without editing the existing code.\n";
            s += "\tClosed to modification, except for bug corrections.\n";
            s += "\tUse interfaces.\n";
            s += "\n\nPress any key to continue.....";
            Console.WriteLine(s);
            Console.ReadLine();

            s = "D - Dependancy Inversion Principal\n";
            s += "\tHigh level modules should not depend on low level modules, both should depend on abstractions.\n";
            s += "\tClients should not be forced to depend upon interfaces they do not use.\n";
            s += "\tDIP removes direct dependencies between classes.\n";
            s += "\tClasses become loosely coupled, making it easier to substitute alternative implementations.\n";
            s += "\n\nPress any key to continue.....";
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
