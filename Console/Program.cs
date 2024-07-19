using Entities;

//nesne ornegi olusturma
Person person = new Person()
{
    FirstName = "Yusufcan",
    LastName = "Adıgüzel",
    BirthDate = DateTime.Parse("09-07-1998"),
};

//nesnenin propertylerini yazdırma
Console.WriteLine($"{person.FirstName} {person.LastName} {person.BirthDate}");

/* 
 Person person = new Person()
{
    FirstName = "Adıgüzel",
    LastName = "Yusufcan",
    BirthDate = DateTime.Parse("09-07-1998"),
};

Console.WriteLine($"{person.FirstName} {person.LastName} {person.BirthDate}");
 */