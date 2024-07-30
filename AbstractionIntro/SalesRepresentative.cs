using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionIntro
{
    internal class SalesRepresentative : Employee
    {
        //ctor
        public SalesRepresentative(string? firstName, string? lastName, string? department, string? role) : base(firstName, lastName, department, role)
        {
        }

        //method overriding
        public override void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Department} - {Role} - Satış Yapılıyor...");
        }
    }
}
