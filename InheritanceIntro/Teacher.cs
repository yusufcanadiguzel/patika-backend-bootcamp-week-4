using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    public class Teacher : Person
    {
        //field
        private decimal _salary;

        //property
        public decimal Salary { get => _salary; set => _salary = value; }

        //maas, ad ve soyad bilgisini yazdirir
        public void GetSalary()
        {
            //inheritance ile ad soyad yazdiran methodu kullanir
            GetName();
            Console.WriteLine($"Maaş: {Salary}");
        }
    }
}
