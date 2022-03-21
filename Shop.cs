using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Shop : IThing
    {
        private string name;
        private Person[] people;
        private Product[] products;
        public string Name { get => name; set => name = value; }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;  
        }
        public void Print()
        {
            Console.WriteLine($"Shop: {name}");
            Console.WriteLine("-- People: --");
            foreach (Person? p in people)
            {
                p.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (Product? p in products)
            {
                p.Print("\t");
            }
        }
    }
}
