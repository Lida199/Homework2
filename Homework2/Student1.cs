using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Student1
    {
        public string name {  get; set; }

        public Student1(string name)
        {
            this.name = name;
        }

        public virtual void Study()
        {
            Console.WriteLine("Studying from student1");
        }

        public virtual void Read()
        {
            Console.WriteLine("Reading from student1");
        }

        public virtual void Write()
        {
            Console.WriteLine("Writing from student1");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Relating from student1");
        } 
    }
}
