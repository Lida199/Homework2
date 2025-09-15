using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Student
    {
        public string name {  get; set; }
        public int age { get; set; }
        public int enrollmentYear { get; set; }

        public Student(string name, int age, int enrollmentYear)
        {
            this.name = name;
            this.age = age; 
            this.enrollmentYear = enrollmentYear;
        }

        public string getRandomSubject()
        {
           string[] subjects = ["Math", "English", "Chemistry", "Georgian", "Biology"];
           string randomSubject = subjects[new Random().Next(0,subjects.Length)];
           return randomSubject;
        }

        public void yearsLeftUntilGraduation()
        {
            int programLength = 4;
            int currentYear = DateTime.Now.Year;
            int graduationYear = this.enrollmentYear + programLength;
            int yearsLeft = graduationYear - currentYear;

            if (yearsLeft < 0)
            {
                yearsLeft = 0; 
            }

            Console.WriteLine($"Years left until graduation: {yearsLeft}");
        }
    }
}
