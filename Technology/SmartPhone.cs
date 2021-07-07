using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string HeadPhones { get; set; } 

        public SmartPhone(string name, int ssd, ulong serial, string headSetType, bool screen) : base(name, ssd, serial, screen)
        {
            HeadPhones = headSetType;
        }
        
        public bool chargeType(string charge)
        {
            if(charge == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}
