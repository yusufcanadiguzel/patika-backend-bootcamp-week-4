using InheritanceIntro;

//ogrenci nesnesi
Student student = new Student()
{
    FirstName = "Yusufcan",
    LastName = "Adıgüzel",
    Id = 1
};

//ogretmen nesnesi
Teacher teacher = new Teacher()
{
    FirstName = "Adıgüzel",
    LastName = "Yusufcan",
    Salary = 1000
};

//degerlerin console'a yazilmasi
student.GetId();
teacher.GetSalary();