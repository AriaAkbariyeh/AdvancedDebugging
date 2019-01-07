using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PerformanceIssues
{
    class MOOM
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
        public void Run()
        {
            Console.WriteLine("Press any keys and check the memory usage of this application, why is it increasing ? ");
            Console.ReadLine();

            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "MyPersonRoot";
            root.Namespace = "http://www.contoso.com";
            root.IsNullable = true;

            while (true)
            {
                Console.WriteLine("Inifite Loop");
                Person p = new Person();
                p.Name = "Aria";
                p.ID = 1;
                p.Age = 25;
                p.Job = "Software engineer";

                XmlSerializer ser = new XmlSerializer(typeof(Person), root);
                string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                Stream s = new FileStream(dir + @"\serilizedPerson.xml", FileMode.Create);
                ser.Serialize(s, p);
                s.Close();

            }
        }
    }
}
