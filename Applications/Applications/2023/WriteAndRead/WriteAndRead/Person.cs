using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAndRead
{
    public class Person
    {
        public string name, surname, tel;
        public Person(string name, string surname, string tel)
        {
            this.name = name;
            this.surname = surname;
            this.tel = tel;
        }
        public void WriteOut()
        {
            Console.WriteLine($"Name: {name}; Surname: {surname}; Tel: {tel}.");
        }
    }
}
