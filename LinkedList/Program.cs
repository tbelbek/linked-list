using System;
using System.Collections.Generic;

namespace SLL
{
    /// <summary>
    /// Client class that runs the program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // Add a few elements to the list.
            var intList = new List<int>() { 5, 8, 9, 1, 2, 3 };
            intList.ForEach(t =>
            {
                list.Add(t);
            });

            // list.Delete(2);
            // list.Delete(5);            
            // list.Delete(1);            
            // list.Delete(3);            
            // list.Delete(4);
            // list.Find(9);
            // list.Delete(8);
            // list.Find(8);                        
            // list.Find(9);

            list.ShowNodes();
            
            // This ensures the command window is displayed in case the program is not run from command prompt.
            Console.ReadLine();
        }
    }
}