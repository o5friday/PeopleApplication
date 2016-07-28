using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Alex", "Ivanov");
            var p2 = new Person("Alex", "Ivanov");
            var p3 = new Person("Alex", "Green");

            Console.WriteLine(p1.Equals(p2)); // true
            Console.WriteLine(p1.Equals(p3)); // false

            var people = new List<Person>()
            {
                new Person("Henry", "Qwerty"),
                new Person("Alex", "Ivanov"),
                new Person("Andrew", "Miles")
            };

            foreach(var person in people.Where(p => p.Equals(p1)))
            {
                Console.WriteLine(person.ToString()); // Alex Ivanov
            }
        }
    }
}
