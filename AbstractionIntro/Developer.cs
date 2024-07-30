using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionIntro
{
    internal class Developer : Employee, IEmployee
    {
        //ctor
        public Developer(string? firstName, string? lastName, string? department, string? role) : base(firstName, lastName, department, role)
        {
        }

        //method overriding
        public void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Department} - {Role} - Kod Yazıyor...");
        }
    }
}
