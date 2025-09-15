using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework2
{
    internal class GoodStudent: Student1
    {
        public GoodStudent(string name) : base(name) { }

        public override void Study()
        {
            Console.WriteLine($"{this.name} studies a lot");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this.name} relaxes little");
        }

    }

}
