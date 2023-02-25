using System;
using System.Xml.Linq;
using Newtonsoft.Json;
namespace PeopleButWorseForms
{
    public partial class Form1 : Form
    {
        public static List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = nametextbox.Text;
            nametextbox.Text = "";
            string surname = surnametextbox.Text;
            surnametextbox.Text = "";
            string phone = phonetextbox.Text;
            phonetextbox.Text = "";
            string jsonMsg = "";
            using (StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\C Sharp\\PeopleButWorseForms\\PeopleButWorseForms\\bin\\Debug\\net7.0-windows\\data.json"))
            {
                jsonMsg = sr.ReadToEnd();
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\C Sharp\\PeopleButWorseForms\\PeopleButWorseForms\\bin\\Debug\\net7.0-windows\\data.json"))
            {
                
                if (jsonMsg == "" || jsonMsg == "[]")
                {
                    jsonMsg = "[{\"name\": \"" + name + "\",\"surname\": \"" + surname + "\", \"phone\": \"" + phone + "\"}]";
                }
                else
                {
                    jsonMsg = jsonMsg.Remove(jsonMsg.Length - 1);
                    jsonMsg += ",{\"name\": \"" + name + "\",\"surname\": \"" + surname + "\", \"phone\": \"" + phone + "\"}]";
                }
                sw.Write(jsonMsg);
                MessageBox.Show("Data saved!", "Saving data");
            }
        }
        private void loadbtn_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\C Sharp\\PeopleButWorseForms\\PeopleButWorseForms\\bin\\Debug\\net7.0-windows\\data.json"))
            {
                string data = sr.ReadToEnd();
                people = JsonConvert.DeserializeObject<List<Person>>(data);
                MessageBox.Show("Data loaded!", "Loading data");
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            foreach(Person p in people)
            {
                listbox.Items.Add(p.ReturnValues());
            }
            MessageBox.Show("Data updated!", "Updating data");
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = listbox.SelectedIndex;
            listbox.Items.RemoveAt(selectedIndex);
            string myData = "";
            using (StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\C Sharp\\PeopleButWorseForms\\PeopleButWorseForms\\bin\\Debug\\net7.0-windows\\data.json"))
            {
                myData = sr.ReadToEnd();
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\C Sharp\\PeopleButWorseForms\\PeopleButWorseForms\\bin\\Debug\\net7.0-windows\\data.json"))
            {
                sw.Flush();
                List<dynamic> dataList = JsonConvert.DeserializeObject<List<dynamic>>(myData);
                dataList.RemoveAt(selectedIndex);
                myData = JsonConvert.SerializeObject(dataList);
                sw.Write(myData);
            }
                MessageBox.Show("Row deleted!", "Deleting row");
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            using (StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\C Sharp\\PeopleButWorseForms\\PeopleButWorseForms\\bin\\Debug\\net7.0-windows\\data.json"))
            {
                sw.Flush();
            }
            MessageBox.Show("All data deleted!", "All data deletion");
        }
    }
}