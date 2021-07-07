using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer 
    {
        public string Brand { get; set; }

        public Laptop(string brand, string name, int ssd, ulong serial, bool screen) : base(name, ssd, serial, screen)
        {
            Brand = brand;
        }

        public bool FileHosting()
        {
            return true;
        }
    }
}
