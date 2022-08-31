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
                employees.Add(new Employee(ran.Next(1, 5),
                    surnames[ran.Next(0, surnames.Length-1)]));
                
            }
            //Diaplaying unsorted List
            Console.WriteLine("Sorted List");
            foreach (Employee i in employees)
            {
                Console.WriteLine(String.Join(" - ", i.depID, i.empSurname));
            }

            //Sorting List            
            for (int i = 0; i < employees.Count -1; i++)
            {
                for (int j = i+1; j < employees.Count; j++)
                {
                    if (employees[i].depID > employees[j].depID)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[i];
                        employees[i] = temp;
                    }
                    if (employees[i].depID == employees[j].depID)
                    {
                        if (employees[i].empSurname.CompareTo(
                            employees[j].empSurname) == 1)
                        {
                            Employee temp = employees[j];
                            employees[j] = employees[i];
                            employees[i] = temp;
                        }
                    }

                }
            }

            //Printing
            Console.WriteLine("Sorted List");
            foreach (Employee i in employees)
            {
                Console.WriteLine(String.Join(" - ", i.depID, i.empSurname));
            }
            
        }
    }
}


