using System;

namespace PeopleButWorseForms
{
    public class Person
    {
        //Variables
        public string name, surname, phone;
        //Constructor
        public Person(string name, string surname, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }
        //Just for write out of the values
        public void WriteOut()
        {
            Console.WriteLine($"Name: {name}; Surname: {surname}; Phone: {phone}.");
        }
        public string ReturnValues()
        {
            return $"Name: {name}; Surname: {surname}; Phone: {phone}.";
        }
    }
}
