// See https://aka.ms/new-console-template for more information
using ODEV_C_.GenericList.Classes;

Console.WriteLine("Hello, World!");

//TOPLAM MESAFE VERİLMEDİĞİ İÇİN BEN DE TOPLAM YAKIT TÜKETİMİNİ MESAFE OLARAK ALDIM

List<Araba> arabalar = new List<Araba>();

arabalar.Add(new Araba("Toyoto", "Corollo", 6.5, 325));
arabalar.Add(new Araba("BMW", "X5", 9.0, 450));
arabalar.Add(new Araba("Mercedes", "C200", 8.2, 410));

foreach (var araba in arabalar)
{
    Console.WriteLine($"Marka:{araba.Marka}, Model:{araba.Model}, 100 KM'de yaktığı yakıt:{araba.BenzinHarcamasi} litre, Toplam Yakıt Tüketimi:{araba.ToplamYakitTüketimi} litre");
}



