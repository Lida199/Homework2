using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal abstract class FileWorker
    {
        internal readonly int MaxSize = 128;
        public abstract string Extention {  get; set; }
        public virtual void Write()
        {
            Console.WriteLine($"I can write to {this.Extention} file with max storage {this.MaxSize}");
        }

        public virtual void Read()
        {
            Console.WriteLine($"I can read from {this.Extention} file with max storage {this.MaxSize}");
        }

        public virtual void Delete()
        {
            Console.WriteLine($"I can delete from {this.Extention} file with max storage {this.MaxSize}");
        }

        public virtual void Edit()
        {
            Console.WriteLine($"I can edit {this.Extention} file with max storage {this.MaxSize}");
        }
    }
}
