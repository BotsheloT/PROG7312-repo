using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> cities = new LinkedList<string>();
            cities.AddLast("Liverpool");
            cities.AddLast("Shanghai");
            cities.AddLast("Wein");
            cities.AddLast("Barcelona");
            cities.AddLast("Napoli");

            //Add Stockholm as the first city
            cities.AddFirst("Stockholm");

            //Add Malmo after Shanghai
            LinkedListNode<string> shangNode = cities.Find("Shanghai");
            cities.AddAfter(shangNode, "Shanghai");

            //Add Triest Before Shanghai
            cities.AddBefore(shangNode,"Shanghai");

            //Displaying the Nodes
            foreach (string item in cities)
            {
                Console.WriteLine(item);

            //Display what comes before Shanghai
            Console.WriteLine("==============================================");
            Console.WriteLine(shangNode.Previous.Value);
            Console.WriteLine("==============================================");            
            
        }
    }
}

