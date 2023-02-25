using System;
using System.IO;
using Newtonsoft.Json;

namespace WriteAndRead
{
    public class Program
    {
        public static string[] names = { "Petr", "Thomas", "Mark", "Pablo", "John" };
        public static string[] surnames = { "Kejklíček", "Veselý", "Smith", "Novák", "Chytrý" };
        public static string[] tel = { "606 696 969", "890 800 189", "000 000 000", "567 918 186", "651 135 656" };

        public static List<Person> people = new List<Person>();
        public static void Main(string[] args)
        {
            Writer();
            Reader();
            PeopleData();
        }
        public static void Writer()
        {
            string msg = "[";
            using (StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\C Sharp\\WriteAndRead\\WriteAndRead\\bin\\Debug\\net7.0\\data.json"))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    msg += "{\"name\": \"" + names[i] + "\",\"surname\": \"" + surnames[i] + "\",\"tel\": \"" + tel[i] + "\"}";
                    if (i != names.Length - 1)
                    {
                        msg += ",";
                    }
                }
                msg += "]";
                sw.Write(msg);
                Console.WriteLine("Data written to file successfully. //Yay!");
            }
        }
        public static void Reader()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\admin\\Desktop\\C Sharp\\WriteAndRead\\WriteAndRead\\bin\\Debug\\net7.0\\data.json"))
            {
                string data = reader.ReadToEnd();
                List<Person> peopleJSON = JsonConvert.DeserializeObject<List<Person>>(data);
                Console.WriteLine(data);
                for (int i = 0; i < peopleJSON.Count; i++)
                {
                    Person person = peopleJSON[i];
                    people.Add(person);
                }
                Console.WriteLine("Data successfully loaded.");
            }
        }
        public static void PeopleData()
        {
            foreach(Person p in people)
            {
                p.WriteOut();
            }
            Console.WriteLine("Data has been written out succesfully.");
        }
    }
}