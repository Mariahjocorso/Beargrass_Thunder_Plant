using System;
using System.Text;
using System.Text.Json;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many types of flowers do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());



            var recordList = new List<Flowers>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new Flowers();

                Console.WriteLine("Enter the flower color: ");
                entry.Color = Console.ReadLine();

           
                recordList.Add(new Flowers() { Color = entry.Color });
            }



            // Print out the list of records using Console.WriteLine()
            foreach (var entry in recordList)
                Console.WriteLine("\nFlower: " + entry.Color + "\n");

        }
    }
}