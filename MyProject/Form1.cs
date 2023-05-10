using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib.MyStudent;
using static System.Windows.Forms.ListView;

namespace MyProject
{
    public partial class Form1 : Form
    {
        List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            students.Add(new Student("Ivan",20,"ItStep"));
            students.Add(new Student("Oleg", 13, "Politex"));
            students.Add(new Student("Irina", 22, "ItStep"));

            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Возраст");
            listView1.Columns.Add("Университет");
            listView1.View = View.Details;
            foreach (var a in students)
            {
                ListViewItem rez = listView1.Items.Add(a.Name);
                rez.SubItems.Add(a.Age.ToString());
                rez.SubItems.Add(a.Academy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textToAdd = textBox1.Text;
            string textToAdd2 = textBox2.Text;
            string textToAdd3 = textBox3.Text;
            ListViewItem item = new ListViewItem(textToAdd);
            item.SubItems.Add(textToAdd2);
            item.SubItems.Add(textToAdd3);
            listView1.Items.Add(item);
        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Academy { get; set; }

            public Student(string name, int age, string academy)
            {
                Name = name;
                Age = age;
                Academy = academy;
            }
        }
    }
}
