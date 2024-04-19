using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class IssuedBook : Book
    {
        List<Student> students;
        public IssuedBook()
        {
            students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            this.students.Add(student);
        }

        public void removeStudent(Student student) 
        {
            this.students.Remove(student);
        }
    }
}
