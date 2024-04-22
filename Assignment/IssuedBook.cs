using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Assignment
{
    public class IssuedBook : Book
    {
        List<Student> students;
        public IssuedBook()
        {
            students = new List<Student>();
        }

        public List<Student> Students { get => students; set => students = value; }

        public void addStudent(Student student)
        {
            this.students.Add(student);
        }

        public void removeStudent(Student student) 
        {
            this.students.Remove(student);
        }

        public void removeStudent(List<Student> students)
        {
            foreach(Student s in students)
            {
                this.students.Remove(s);
            }
        }

        public void SaveToFile(string fileName)
        {
            XmlSerializer obj = new XmlSerializer(typeof(List<Student>));
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                obj.Serialize(sw, this.students);
            }
        }

        public List<Student> ReadFromFile(string fileName)
        {
            XmlSerializer obj = new XmlSerializer(typeof(List<Student>));
            using (StreamReader sw = new StreamReader(fileName))
            {
                return (List<Student>)obj.Deserialize(sw);
            }
        }

        public List<Student> FindStudent(string id = null,string bookId = null)
        {
            var query = students.AsQueryable();
            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(b => b.Id.Equals(id,StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(bookId))
            {
                query = query.Where(b => b.Books.Id.Equals(bookId,StringComparison.OrdinalIgnoreCase));
            }
            return query.ToList();
        }

        public int countBook(List<Student> s)
        {
            int count = 0;
            foreach(Student student in s)
            {
                count += (student.Quanti);
            }
            return count;
        }

    }
}
