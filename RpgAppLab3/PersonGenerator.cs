using System;
using System.Collections.Generic;
using System.Text;

namespace RpgAppLab3
{
    class PersonGenerator
    {

        Random rnd = new Random();
        string[] allNames = new[] { "Briana", "Ben", "David",
            "Dana", "Felicia", "Felix", "Frodo", "Hobbit", "Legolas", "Aragorn" };
        List<Person> persons = new List<Person>();

        apgdadpjgadpjadpjgadpgjadgaadg

        public PersonGenerator()
        {
            foreach (var name in allNames)
            {
                var person = new Person();
                person.Name = name;
                persons.Add(person);
            }
        }

        public string GetRandom()
        {
            return persons[rnd.Next(0, persons.Count)].Name;
        }
    }
}
