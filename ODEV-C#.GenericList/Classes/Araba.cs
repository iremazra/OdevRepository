using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_C_.GenericList.Classes
{
    internal class Araba
    {
        private string _marka;
        private string _model;
        private double _benzinHarcamasi;
        private double _toplamMesafe;
        private double _toplamYakitTuketimi;

        public Araba(string marka, string model, double benzinHarcamasi,double toplamMesafe)
        {
            _marka = marka;
            _model = model;
            _benzinHarcamasi = benzinHarcamasi;
            _toplamMesafe = toplamMesafe;
            _toplamYakitTuketimi= (_toplamMesafe / 100) * _benzinHarcamasi;

        }

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double BenzinHarcamasi
        {  
            get { return _benzinHarcamasi; }
            set { _benzinHarcamasi = value; }
        }

        public double ToplamMesafe
        {   
            get { return _toplamMesafe; }
            set { _toplamMesafe = value; }
        }

        public double ToplamYakitTüketimi
        {
            get { return _toplamYakitTuketimi; }
            set { _toplamYakitTuketimi = value; }
        }
    }
}
