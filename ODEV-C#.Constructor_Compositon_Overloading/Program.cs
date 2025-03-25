using ODEV_C_.Constructor_Compositon_Overloading.Classes;
using System.Collections;

Kapi kapi = new Kapi(4);
Kasa kasa = new Kasa("sedan");
Pencere pencere = new Pencere(4);
Marka marka = new Marka("BMW");
Araba araba=new Araba(kasa, marka,kapi,pencere,2000000,"X5");

araba.ArabaCiktisi();

Console.WriteLine("*********************************************");

Matematik matematik = new Matematik();

Console.WriteLine("5+6= "+matematik.Toplama(5, 6));
Console.WriteLine("5+6+7= "+matematik.Toplama(5, 6, 7));
Console.WriteLine("8.545+6.589= "+matematik.Toplama(8.545, 6.589));

Console.WriteLine("5x6=" + matematik.Carpma(5, 6));
Console.WriteLine("5x6x7="+ matematik.Carpma(5, 6, 7));
Console.WriteLine("8.545x6.589=" + matematik.Carpma(8.545, 6.589));

ArrayList arrayList = new();

string x1 = "Azra";
string x2 = x1;
x1= "Berra";
Console.WriteLine(x1 + x2);
