using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class ClassRoom
    {

        private List<Student1> students { get; set; }
        public ClassRoom(List<Student1> students)
        {
            this.students = students;
        }

        public void getAllStudentInfo()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"--- {student.name} ---");
                student.Study();
                student.Read();
                student.Write();
                student.Relax();
            }
        }
    }
}
