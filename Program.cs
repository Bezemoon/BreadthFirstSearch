using System;
using System.Collections.Generic;

namespace Breadth_first_search
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person You = new Person("You", "Programmer");
            Person Alice = new Person("Alice", "Chessman");
            Person Claire = new Person("Claire", "Hairdresser");
            Person Bob = new Person("Bob", "Architect");
            Person Anuj = new Person("Anuj", "Blogger");
            Person Peggi = new Person("Peggi", "Fisherman");
            Person Tom = new Person("Tom", "Athlete");
            Person Jonny = new Person("Jonny", "MangoSeller");

            Dictionary<Person, Person[]> perosonGraph = new Dictionary<Person, Person[]>
            {
                [You] = new[] {Alice, Claire, Bob},
                [Alice] = new[] {Peggi},
                [Claire] = new[] {Tom, Jonny},
                [Bob] = new[] {Anuj, Claire},
                [Anuj] = new Person[] { },
                [Peggi] = new Person[] { },
                [Tom] = new Person[] { },
                [Jonny] = new Person[] { }
            };

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            try
            {
                Person foundling = bfs.Search(perosonGraph, You);
                Console.WriteLine($">>> {foundling.Name} is mango seller! <<<");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}