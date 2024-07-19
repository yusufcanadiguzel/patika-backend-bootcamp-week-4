using TechStore;

string userChoice;
bool isFinished = false;

Console.WriteLine("Hoşgeldiniz\n");

do
{
    //yapilabilecek islemler
    Console.WriteLine("1 - Telefon Kaydı");
    Console.WriteLine("2 - Bilgisayar Kaydı");

    //kullanici girisi alir
    Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz (1/2): ");
    userChoice = Console.ReadLine()!;

    switch (userChoice)
    {
        //telefon kaydi
        case "1":
            var phone = Product.SaveProduct(true);
            phone.GetInfo();
            break;
        //bilgisayar kaydi
        case "2":
            var computer = Product.SaveProduct(false);
            computer.GetInfo();
            break;
        //hatali giris
        default:
            Console.WriteLine("Hatalı giriş yaptınız.");
            break;
    }

    //islem tekrari isteniyor mu
    Console.Write("Tekrar işlem yapmak ister misiniz? (e/h): ");
    isFinished = (Console.ReadLine()! == "e") ? false : true;

} while (!isFinished);

