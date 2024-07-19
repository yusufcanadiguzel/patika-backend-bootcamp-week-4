namespace Entities
{
    public class Person
    {
        private string? _firstName;
        private string? _lastName;
        private DateTime _birthDate;

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

        //dogum tarihi
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
    }
}
