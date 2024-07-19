using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class SmartPhone : Product
    {
        //field
        private bool _isLicenced;

        //ctor
        public SmartPhone(string? serialNumber, string? name, string? description, string? operatingSystem, bool isLicenced) : base(serialNumber, name, description, operatingSystem)
        {
            IsLicenced = isLicenced;

            SuccessfulSave();
        }

        //prop
        public bool IsLicenced { get => _isLicenced; set => _isLicenced = value; }

        //urun bilgisinin ciktisini yazdirir
        public override void GetInfo()
        {
            string isLicenced = (IsLicenced) ? "Evet" : "Hayır";

            base.GetInfo();
            Console.WriteLine($"Ürün Türkiye'de lisanslı mı?: {isLicenced}\n");
        }

        //urun ismini yazdirir
        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Name}");
        }
    }
}
