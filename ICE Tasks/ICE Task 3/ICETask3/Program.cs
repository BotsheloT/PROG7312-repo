using System;
using System.Collections;
using System.Collections.Generic;

namespace ICETask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialised Array with employee surnames
            string[] surnames = {"Foreman", "Kelso", "Wayne", "Gambino",
                                 "Tenneson", "West", "Zoldyck", "Freecss",
                                 "Carter", "Tenma"};

            //List for Employee objects
            List<Employee> employees = new List<Employee>();

            //Random object to generate random result
            Random ran = new Random();        

            //Generating and storing list IDs
            for (int i =0; i < 8; i++)
            {
                employees.Add(new Employee(ran.Next(1, 5), surnames[i]));
                
            }
            //Diaplaying unsorted List
            foreach (object em in employees)
            {
                Console.WriteLine(em);
            }

            //Sorting List
            for ()
            {
                for ()
                {

                }
            }
        }
    }
}

