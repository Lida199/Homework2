using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Txt: FileWorker
    {
        public override string Extention { get; set; }

        public Txt(string Extention) { this.Extention = Extention;}

        public override void Read()
        {
            Console.WriteLine($"Overriding read method from derived class. File extention is {Extention} and max size is {MaxSize}");
        }
    }
}
