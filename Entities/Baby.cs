using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Baby
    {
        //dogum tarihi
        public DateTime BirthDate { get; set; }
        //ad
        public string? FirstName { get; set; }
        //soyad
        public string? LastName { get; set; }

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
