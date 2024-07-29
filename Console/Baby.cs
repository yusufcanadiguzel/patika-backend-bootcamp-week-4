using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Baby
    {
        private DateTime _birthDate;
        private string? _firstName;
        private string? _lastName;

        //dogum tarihi
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        //ad
        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        //soyad
        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        //default constructor
        public Baby()
        {
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        //dogum tarihi, ad ve soyad alanlarini instance olustururken atama
        public Baby(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
