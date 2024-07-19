using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal abstract class Product
    {
        //field
        private DateTime _productionDate;
        private string? _serialNumber;
        private string? _name;
        private string? _description;
        private string? _operatingSystem;

        //ctor
        public Product(string? serialNumber, string? name, string? description, string? operatingSystem)
        {
            ProductionDate = DateTime.Now;
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperatingSystem = operatingSystem;
        }

        //prop
        public DateTime ProductionDate { get => _productionDate; set => _productionDate = value; }
        public string? SerialNumber { get => _serialNumber; set => _serialNumber = value; }
        public string? Name { get => _name; set => _name = value; }
        public string? Description { get => _description; set => _description = value; }
        public string? OperatingSystem { get => _operatingSystem; set => _operatingSystem = value; }

        //urun bilgisini yazdirir
        public virtual void GetInfo()
        {
            Console.WriteLine($"Üretim tarihi: {ProductionDate}");
            Console.WriteLine($"Seri numarası: {SerialNumber}");
            Console.WriteLine($"İsim: {Name}");
            Console.WriteLine($"Açıklama: {Description}");
            Console.WriteLine($"İşletim sistemi: {OperatingSystem}");
        }

        //urun ismini yazdirir
        public virtual void GetProductName()
        {
            Console.WriteLine($"Ürününüzün adı: {Name}");
        }

        //urun kaydeder, kosula gore iki farklı nesneden birisini olusturur
        public static Product SaveProduct(bool isPhone)
        {
            string serialNumber, name, description, operatingSystem;

            Console.WriteLine("---------------------------------------");

            //seri numarasini alir
            Console.Write("Ürünün seri numarasını giriniz: ");
            serialNumber = Console.ReadLine()!;
            Console.WriteLine();

            //adi alir
            Console.Write("Ürün adını giriniz: ");
            name = Console.ReadLine()!;
            Console.WriteLine();

            //aciklamayi alir
            Console.Write("Ürün açıklamasını giriniz: ");
            description = Console.ReadLine()!;
            Console.WriteLine();

            //isletim sistemini alir
            Console.Write("Ürünün işletim sistemini giriniz: ");
            operatingSystem = Console.ReadLine()!;
            Console.WriteLine();

            if (isPhone)
            {
                //lisansi alir
                Console.Write("Ürünün lisanslı mı? (e/h): ");
                bool isLicenced = (Console.ReadLine()! == "e") ? true : false;
                Console.WriteLine();

                return new SmartPhone(serialNumber: serialNumber, name: name, description: description, operatingSystem: operatingSystem, isLicenced: isLicenced);
            }
            else
            {
                //usb port sayisini alir
                Console.Write("Usb port sayisini giriniz: ");
                int usbPortCount = Convert.ToInt32(Console.ReadLine()!);
                Console.WriteLine();

                return new Computer(serialNumber: serialNumber, name: name, description: description, operatingSystem: operatingSystem, usbPortCount: usbPortCount);
            }
            
        }

        //islem basarili yazdirir
        public void SuccessfulSave()
        {
            Console.WriteLine("Ürün başarıyla kaydedildi.");
        }
    }
}
