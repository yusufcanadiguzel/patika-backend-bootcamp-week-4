using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionIntro
{
    //base class
    internal abstract class Employee
    {
        //field
        private string? _firstName;
        private string? _lastName;
        private string? _department;
        private string? _role;

        //ctor
        protected Employee(string? firstName, string? lastName, string? department, string? role)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Role = role;
        }

        //prop
        public string? FirstName { get => _firstName; set => _firstName = value; }
        public string? LastName { get => _lastName; set => _lastName = value; }
        public string? Department { get => _department; set => _department = value; }
        public string? Role { get => _role; set => _role = value; }

        //method
        public abstract void Work();
    }
}
