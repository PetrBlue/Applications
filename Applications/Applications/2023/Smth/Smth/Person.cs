using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smth
{
    public class Person
    {
        //Variables
        public string name, surname, tel;
        //Constructor
        public Person(string name, string surname, string tel)
        {
            this.name = name;
            this.surname = surname;
            this.tel = tel;
        }
        //Just for write out of the values
        public void WriteOut()
        {
            Console.WriteLine($"Name: {name}; Surname: {surname}; Tel: {tel}.");
        }
    }
}
