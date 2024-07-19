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

//instance olusturma ve ctor ile deger atama
Baby baby = new Baby(firstName: "Yusufcan", lastName: "Adıgüzel");