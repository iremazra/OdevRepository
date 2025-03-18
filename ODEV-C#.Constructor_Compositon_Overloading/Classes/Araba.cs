using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_C_.Constructor_Compositon_Overloading.Classes
{
    public  class Araba
    {
        public Kasa _kasa;
        public Marka _marka;
        public Kapi _kapi;
        public Pencere _pencere;
        public float fiyat;
        public string model;

        public Araba(Kasa kasa, Marka marka, Kapi kapi, Pencere pencere,float fiyat, string model)
        {
            _kasa = kasa;
            _marka = marka;
            _kapi = kapi;
            _pencere = pencere;
            this.fiyat = fiyat;
            this.model = model;
        }

        public float FiyatNedir(float fiyat)
        {
            return fiyat;
        }

        public string ModelNedir(string model)
        {
            return model;
        }
        public void ArabaCiktisi()
        {
            Console.WriteLine("Arabanın markası " + _marka.marka + ", " +
                               "modeli " + model + ", " +
                               "kapı sayısı " + _kapi.kapiSayisi + ", " +
                               "pencere sayısı " + _pencere.pencereSayisi + ", "+
                               "kasası " + _kasa.kasa + ", " +
                               "fiyatı " + fiyat + " TL'dir.");

        }
    }
}
