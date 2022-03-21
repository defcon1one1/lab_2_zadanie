using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Fruit : Product
    {
        private int count;
        public int Count { get => count; set => count = value; }

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{Name} ({count} fruits)");
        }
    }
}
