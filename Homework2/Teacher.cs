using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Teacher
    {
        private string name {  get; set; }  
        private bool isCertified {  get; set; } 

        public Teacher(string name, bool isCertified)
        {
            this.name = name;        
            this.isCertified = isCertified;
        }

        public void getSubjectFromStudent(string subject)
        {
            if(subject.ToLower() == "math")
            {
                int number1 = new Random().Next(0, 100);
                int number2 = new Random().Next(0, 100);
                int sum = number1 + number2;
                Console.WriteLine($"Random subject was :{subject}, number 1 is {number1}, number 2 is {number2}, sum is {sum}");
            }else if(subject.ToLower() == "chemistry")
            {
                Console.WriteLine($"Random subject was :{subject}, here is the formula");

            }
            else if (subject.ToLower() == "english")
            {
                Console.WriteLine($"Random subject was :{subject}, here is some english text");
            }
            else
            {
                Console.WriteLine($"Random subject was :{subject}, we have zero comptenence in it");
            }
        }
    }
}
