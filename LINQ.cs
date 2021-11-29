using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    class LINQ :IStrategy
    {
        List<Student> info = new List<Student>();
        XDocument doc = new XDocument();
        public LINQ(string path) 
        {
            doc = XDocument.Load(path);
        }

        public List<Student> Algorithm(Student student, string path) 
        {
            List<XElement> match = (from val in doc.Descendants("students")
                                    where
                                    ((student.Speciality == null || student.Speciality == val.Parent.Parent.Attribute("SPECIALITY").Value) &&
                                    (student.Group == null || student.Group == val.Parent.Parent.Attribute("GROUP").Value) &&
                                    (student.Room == null || student.Room == val.Parent.Parent.Attribute("ROOM").Value) &&
                                    (student.Surname == null || student.Surname == val.Parent.Parent.Attribute("SURNAME").Value) &&
                                    (student.Name == null || student.Name == val.Parent.Parent.Attribute("NAME").Value) &&
                                    (student.Phonenumber == null || student.Phonenumber == val.Parent.Parent.Attribute("PHONENUMBER").Value))
                                    select val).ToList();
            foreach (XElement obj in match) 
            {
                Student student1 = new Student();
                student1.Speciality = obj.Parent.Parent.Attribute("SPECIALITY").Value;
                student1.Group = obj.Parent.Parent.Attribute("GROUP").Value;
                student1.Room = obj.Parent.Parent.Attribute("ROOM").Value;
                student1.Surname = obj.Parent.Parent.Attribute("SURNAME").Value;
                student1.Name = obj.Parent.Parent.Attribute("NAME").Value;
                student1.Phonenumber = obj.Parent.Parent.Attribute("PHONENUMBER").Value;
                info.Add(student1);

            }
            return info;
        }
    }
}
