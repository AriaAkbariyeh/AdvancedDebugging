using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClasses
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public int ID { get; set; }

        public Person() { }
        public Person(int id, string name, int age, string job)
        {
            ID = id;
            Name = name;
            Job = job;
            Age = age;
        }
    }
}
