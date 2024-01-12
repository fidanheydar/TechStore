using System;
using System.Collections.Generic;
using System.Text;

namespace TechStore
{
    internal class Notebook:Product
    {
        public Notebook(string name, double price) : base(name, price)
        {

        }
        public Notebook(string name, double price, int storage) : base(name, price)
        {
            Storage = storage;
        }
        public int Storage;
    }
}
