using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer cmp = new Computer("HP", 512, 7896325895412, true);
            cmp.UniqueId();

            Laptop laptop = new Laptop("MSI", "Drag", 1028, 1234567896321, true);

            (laptop as Computer).UniqueId();
            
        }
    }
}
