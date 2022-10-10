using System;
using System.Collections.Generic;

namespace Breadth_first_search
{
    public class BreadthFirstSearch
    {
        public Person Search(Dictionary<Person, Person[]> graph, Person startPerson)
        {
            Queue<Person> personQueue = new Queue<Person>();
            AddPerosonsFromArray(ref personQueue, graph, startPerson);

            List<Person> verifiedPesrsons = new List<Person>();

            while (true)
            {
                Person person = personQueue.Dequeue();
                if (!CheckVisitation(verifiedPesrsons, person))
                {
                    if (CheckIsMangoSeller(person))
                        return person;

                    AddPerosonsFromArray(ref personQueue, graph, person);
                    
                    verifiedPesrsons.Add(person);   
                }
                
                if (personQueue.Count == 0)
                    break;
            }

            throw new Exception(">>> There are no mango sellers in your network. <<<");
        }

        private void AddPerosonsFromArray(ref Queue<Person> personQueue, Dictionary<Person, Person[]> graph, Person person)
        {
            Person[] persons = graph[person];

            for (int i = 0; i < persons.Length; i++)
            {
                personQueue.Enqueue(persons[i]);
            }
        }

        private bool CheckIsMangoSeller(Person person)
        {
            return person.Job == "MangoSeller";
        }

        private bool CheckVisitation(List<Person> verifiedPersons, Person person)
        {
            for (int i = 0; i < verifiedPersons.Count; i++)
            {
                if (verifiedPersons[i] == person)
                    return true;
            }

            return false;
        }
    }
}