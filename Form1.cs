using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; 

namespace XML
{
    public partial class Form1 : Form
    {
        string path = "DataBase.xml";
        List<Student> final = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Student _student = OurStudent();
            if (LINQ.Checked) 
            {
                IStrategy CurrentStrategy = new LINQ(path);
                final = CurrentStrategy.Algorithm(_student, path);
                Output(final);
            }
            if (DOM.Checked)
            {
                IStrategy CurrentStrategy = new DOM(path);
                final = CurrentStrategy.Algorithm(_student, path);
                Output(final);
            }
           /* if (SAX.Checked)
            {
                IStrategy CurrentStrategy = new SAX(path);
                final = CurrentStrategy.Algorithm(_student, path);
                Output(final);
            }*/
        }
        private Student OurStudent() 
        {
            string[] info = new string[6];
            if (Speciality.Checked) info[0] = Convert.ToString(SpecialityBox.Text);
            if (Group.Checked) info[1] = Convert.ToString(GroupBox.Text);
            if (Room.Checked) info[2] = Convert.ToString(RoomBox.Text);
            if (Surname.Checked) info[3] = Convert.ToString(SurnameBox.Text);
            if (Name.Checked) info[4] = Convert.ToString(NameBox.Text);
            if (PhoneNumber.Checked) info[5] = Convert.ToString(PhoneBox.Text);
            Student IdealStudent = new Student(info);
            return IdealStudent;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Speciality.Checked = false;
            Group.Checked = false;
            Room.Checked = false;
            Surname.Checked = false;
            Name.Checked = false;
            PhoneNumber.Checked = false;
            SpecialityBox.Text = null;
            GroupBox.Text = null;
            RoomBox.Text = null;
            SurnameBox.Text = null;
            NameBox.Text = null;
            PhoneBox.Text = null;
            LINQ.Checked = false;
            DOM.Checked = false;
            SAX.Checked = false;
        }
        private void Output(List<Student> final) 
        {
            int i = 1;
            Console.WriteLine("Alg+");
            foreach (Student n in final) 
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                richTextBox1.AppendText("Speciality:" + n.Speciality + "\n");
                richTextBox1.AppendText("Group:" + n.Group + "\n");
                richTextBox1.AppendText("Room:" + n.Room + "\n");
                richTextBox1.AppendText("Surname:" + n.Surname + "\n");
                richTextBox1.AppendText("Name:" + n.Name + "\n");
                richTextBox1.AppendText("Phone Number :" + n.Phonenumber + "\n");
                richTextBox1.AppendText("--------------------------------------------------\n");
            }
        }
        public void GetAllStudents() 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            XmlNodeList elem = doc.SelectNodes("//speciality");
            foreach (XmlNode e in elem) 
            {
                XmlNodeList list1 = e.ChildNodes;
                foreach (XmlNode el in list1) 
                {
                    XmlNodeList list2 = el.ChildNodes;
                    foreach (XmlNode ell in list2) 
                    {
                        string speciality = ell.ParentNode.Attributes.GetNamedItem("SPECIALITY").Value;
                        if (!SpecialityBox.Items.Contains(speciality))
                            SpecialityBox.Items.Add(speciality);
                        string group = ell.ParentNode.Attributes.GetNamedItem("GROUP").Value;
                        if (!SpecialityBox.Items.Contains(group))
                            SpecialityBox.Items.Add(group);
                        string room = ell.ParentNode.Attributes.GetNamedItem("ROOM").Value;
                        if (!SpecialityBox.Items.Contains(room))
                            SpecialityBox.Items.Add(room);
                        string surname = ell.ParentNode.Attributes.GetNamedItem("SURNAME").Value;
                        if (!SpecialityBox.Items.Contains(surname))
                            SpecialityBox.Items.Add(surname);
                        string name = ell.ParentNode.Attributes.GetNamedItem("NAME").Value;
                        if (!SpecialityBox.Items.Contains(name))
                            SpecialityBox.Items.Add(name);
                        string phonenumber = ell.ParentNode.Attributes.GetNamedItem("PHONENUMBER").Value;
                        if (!SpecialityBox.Items.Contains(phonenumber))
                            SpecialityBox.Items.Add(phonenumber);
                        GroupBox.Items.Add(ell.ParentNode.Attributes.GetNamedItem("Group").Value);
                        GroupBox.Items.Add(ell.ParentNode.Attributes.GetNamedItem("ROOM").Value);
                        GroupBox.Items.Add(ell.ParentNode.Attributes.GetNamedItem("SURNAME").Value);
                        GroupBox.Items.Add(ell.ParentNode.Attributes.GetNamedItem("NAME").Value);
                        GroupBox.Items.Add(ell.ParentNode.Attributes.GetNamedItem("PHONENUMBER").Value);

                    }
                }
            }
        }
    }
}
