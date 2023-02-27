using System;
using System.IO;
using Newtonsoft.Json;

namespace Smth
{
    public class Program
    {
        //All variables
        public static string[] names =
        {
            "John", "Pete", "Peter", "Paul"
        };
        public static string[] surnames =
        {
            "Novak", "Pavel", "Kejklicek", "Douda"
        };
        public static string[] tel =
        {
            "606 060 606", "506 056 560", "846 654 646", "465 468 456"
        };
        public static List<Person> people;
        public static void Main(string[] args)
        {
            Write();
            Read();
            WriteOutData();
        }
        public static void Write()
        {
            //declaration, can be declared wo using, but then it would have to be closed
            using (StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\C Sharp\\Smth\\Smth\\bin\\Debug\\net7.0\\data.json"))
            {
                //declaration of smth that I will then save
                string jsonMsg = "[";
                //looping and saving thru all values
                for (int i = 0; i < names.Length; i++)
                {
                    jsonMsg += "{\"name\": \"" + names[i] + "\",\"surname\": \"" + surnames[i] + "\",\"tel\": \"" + tel[i] + "\"}";
                    if (i != names.Length - 1)
                    {
                        jsonMsg += ",";
                    }
                }
                jsonMsg += "]";
                //saves it to the file
                sw.Write(jsonMsg);
                //debug
                Console.WriteLine("Data saved.");
            }
        }
        public static void Read()
        {
            //declaration, can be declared wo using, but then it would have to be closed
            using (StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\C Sharp\\Smth\\Smth\\bin\\Debug\\net7.0\\data.json"))
            {
                //reads the data
                string data = sr.ReadToEnd();
                //converts it to a List with type Person
                people = JsonConvert.DeserializeObject<List<Person>>(data);
                //Just for debug
                Console.WriteLine("Data loaded.");
            }
        }
        //Just for debug
        public static void WriteOutData()
        {
            foreach (Person p in people)
            { 
                p.WriteOut();
            }
        }
    }
}