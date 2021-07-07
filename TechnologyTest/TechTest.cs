
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTest
{
    [TestClass]
    public class TechTest
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(0, 0);
        }

        private Computer computer;
        [TestInitialize]
        public void CreateComputer()
        {
            computer = new Computer("MSI", 1028, 9865432178536, true);
        }
        [TestMethod]
        public void PowerOn()
        {
            Assert.AreEqual("On",computer.powerOn());
        }
        [TestMethod]
        public void PowerOff()
        {
            Assert.AreEqual("Off", computer.powerOff());
        }
        [TestMethod]
        public void Screen()
        {
            Assert.IsTrue(computer.Screen);
        }
        [TestMethod]
        public void LaptopInheritsBase()
        {
            Laptop laptop = new Laptop("ASUS", "AOG", 512, 8745632896411, true);
            Assert.IsTrue(laptop.Screen);
        }
        [TestMethod]
        public void LaptopPowerOn()
        {
            Laptop laptop = new Laptop("ASUS", "AOG", 512, 8745632896411, true);
            Assert.AreEqual("On", laptop.powerOn());
        }
        [TestMethod]
        public void LaptopPowerOffEquals()
        {
            Laptop laptop = new Laptop("ASUS", "AOG", 512, 8745632896411, true);
            Assert.AreEqual(computer.powerOff(), laptop.powerOff());
        }
        
            
        

        [TestMethod]
        public void SmartPhoneFastChargeTrue()
        {
            SmartPhone samsung = new SmartPhone("Samsung", 128, 3698521478963, "wired", true);
            Assert.IsTrue(samsung.chargeType("yes"));
        }

        [TestMethod]
        public void SmartPhoneFastChargeFalse()
        {
            SmartPhone samsung = new SmartPhone("Samsung", 128, 3698521478963, "wired", true);
            Assert.IsFalse(samsung.chargeType("no"));
        }
        [TestMethod]
        public void SmartPhonePowerOn()
        {
            SmartPhone samsung = new SmartPhone("Samsung", 128, 3698521478963, "wired", true);
            Assert.AreEqual("On", samsung.powerOn());
        }
            
            
    }
}
