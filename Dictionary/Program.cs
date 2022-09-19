using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation of dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            //Adding items to Dictionary
            employees.Add(1, "Chris Hanson");
            employees.Add(2, "Steve Backster");
            employees.Add(3, "Fin Murtins");
            employees.Add(4, "Simon West");
            employees.Add(5, "Bojack Horseman");            
        }
    }
}

