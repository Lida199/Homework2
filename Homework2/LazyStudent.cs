using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class LazyStudent: Student1
    {
        public LazyStudent(string name) : base(name) { }

        public override void Study()
        {
            Console.WriteLine($"{this.name} studies little");
        }

        public override void Relax()
        {
            Console.WriteLine($"{this.name} relaxes a lot");
        }

    }
}
