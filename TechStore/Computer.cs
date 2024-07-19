using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Computer : Product
    {
        //field
        private int _usbPortCount;

        //ctor
        public Computer(string? serialNumber, string? name, string? description, string? operatingSystem, int usbPortCount) : base(serialNumber, name, description, operatingSystem)
        {
            UsbPortCount = usbPortCount;
        }

        //prop value'nin 2 ya da 4 olmamasi durumunda hata verir ve -1 atar
        public int UsbPortCount
        {
            get { return _usbPortCount; }
            set
            {
                if ((value == 2) || (value == 4))
                {
                    _usbPortCount = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Usb Port sayısı 2 veya 4 olabilir.");
                    _usbPortCount = -1;
                }
            }
        }

        //urun bilgisi ciktisini yazdirir
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Usb port sayısı: {UsbPortCount}\n");
        }

        //urun ismini yazdirir
        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Name}");
        }
    }
}
