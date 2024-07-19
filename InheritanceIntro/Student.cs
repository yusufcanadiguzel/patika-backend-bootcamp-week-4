using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    public class Student : Person
    {
        //field
        private int _id;
        
        //property
        public int Id { get => _id; set => _id = value; }

        //id, ad ve soyad bilgisini yazdirir
        public void GetId()
        {
            //inheritance ile ad soyad yazdiran methodu kullanir
            GetName();
            Console.WriteLine($"Numara: {Id}");
        }
    }
}
