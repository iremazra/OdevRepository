using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_C_.AccessModifiers.Classes
{
    internal class User
    {
        private string adSoyad { get; set; }
        private int yas {  get; set; }
        public string Email;

        public string GetAdSoyad()
        { return adSoyad; }

        public void SetAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }

        public int GetYas() { return yas; }
        
        public void SetYas(int yas)
        { this.yas = yas; }
        public void BilgileriGoster()
        {
            Console.WriteLine("Adı-Soyadı: " + GetAdSoyad() + "\n" + "Yaş:" + GetYas());
        }
    }
}
