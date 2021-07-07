using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public readonly bool Screen = true;
        public string Name;
        private ulong _serialNum;
        public int SsdSize;

        public ulong SerialNum 
        {
            get { return _serialNum; }
            set { _serialNum = value; } 
        }

        public string powerOn()
        {
            return "On";
            
        }

        public string powerOff()
        {
            return "Off";
        }

        public override Guid UniqueId()
        {
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid.ToString());
            return guid;
        }

        public Computer(string name, int ssd, ulong serial, bool screen)
        {
            Name = name;
            SsdSize = ssd;
            SerialNum = serial;
            Screen = screen;
            this.Screen = screen;
        }

        
        

        
    }
    
}
