using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Employee
    {
        public string name {  get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string position { get; set; }
        public int[] weeklyAmount { get; set; }

        public Employee(string name,string lastName, 
            int age, string position, int[] weeklyAmount) {
            this.name = name;   
            this.lastName = lastName;   
            this.age = age;
            this.position = position;
            this.weeklyAmount = weeklyAmount;
        }   

        public double weeklyTotal()
        {
            var hourWage = getHourPayByPosition(this.position);

            var totalForAWeek = 0.0;
            for (int i = 0; i < this.weeklyAmount.Length; i++)
            {
                totalForAWeek += ((i < 5) ? 1 : 2) * (weeklyAmount[i] * hourWage + (weeklyAmount[i] > 8 ? ((weeklyAmount[i] - 8) *  5) : 0.0));
            }

            if (weeklyAmount.Sum() > 50)
            {
                totalForAWeek += totalForAWeek * 1.0 / 5.0;
            }

            return totalForAWeek;
        }

        private int getHourPayByPosition(string position)
        {
            if (position.ToLower() == "developer")
            {
                return 30;

            }
            else if (position.ToLower() == "tester")
            {
                return 20;
            }
            else if (position.ToLower() == "manager")
            {
                return 40;
            }
            else
            {
                return 10;
            }
        }

    }
}
