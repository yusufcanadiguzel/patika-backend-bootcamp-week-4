using PatikaLibraryApp;

//instance olusturma
Book book = new Book(name: "Adı Aylin", author: "Ayşe Kulin", pageCount: 398, publisher: "Remzi Kitabevi");

//nesne bilgilerini yazdirma
Console.WriteLine($"Kitap adı: {book.Title}");
Console.WriteLine($"Yazar: {book.Author}");
Console.WriteLine($"Sayfa sayısı: {book.PageCount}");
Console.WriteLine($"Yayımlanma tarihi: {book.PublishDate}");
Console.WriteLine($"Yayımlayıcı: {book.Publisher}");

//Class: Ihtiyac duyulan nesneleri olusturabilmek icin kullanilan blueprinttir.
//Property: Class'in field'larini yonetmek ve erisimlerini kontrol etmek icin kullanilir.
//New: Class'in ram uzerinde bir instance'inin olusturulmasini saglar.
//Constructor: Objenin instance'sinin olustugu anda calisan method'tur.