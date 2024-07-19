using AbstractionIntro;

//nesne olusturma
Developer developer = new Developer(firstName: "Yusufcan", lastName: "Adıgüzel", department: "IT", role: "Yazılım Geliştirici");
SalesRepresentative salesRepresentative = new SalesRepresentative(firstName: "Adıgüzel", lastName: "Yusufcan", department: "Sales", role: "Satış Temsilcisi");

//calisma operasyonu
developer.Work();
salesRepresentative.Work();