using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    public class Person
    {
        //field
        private string? _firstName;
        private string? _lastName;

        //property
        public string? FirstName { get => _firstName; set => _firstName = value; }
        public string? LastName { get => _lastName; set => _lastName = value; }

        //ad ve soyad bilgisini yazdirir
        public void GetName()
        {
            Console.WriteLine($"Ad Soyad: {FirstName} {LastName}");
        }
    }
}
