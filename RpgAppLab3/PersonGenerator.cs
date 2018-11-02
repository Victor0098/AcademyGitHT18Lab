using System;
using System.Collections.Generic;
using System.Text;

namespace RpgAppLab3
{
    class PersonGenerator
    {

        Random rnd = new Random();
        string[] allNames = new[] { "Mr.Bush", "Mr.Mandela", "Mr.Statsminister",
            "Mr.Hussein", "Mr.Hitler", "Mr.KimYungUn", "Mr.Trump", "Mr.Putin", "Mr.Assaad", "Mr.CheGuevara" };
        List<Person> persons = new List<Person>();

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
