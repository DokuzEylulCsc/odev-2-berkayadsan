using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Ders
    {
        private string ders_adi;
        private int ders_kodu;
        public List<Ogrenci> ogrenci;
        public List<Ogretim_Elemani> ogretim_elemani;
        public List<Sube> sube;


        public string Ders_adi { get => ders_adi; set => ders_adi = value; }
        public int Ders_kodu { get => ders_kodu; set => ders_kodu = value; }

        public Ders(string _ders_adi,int _ders_kodu)
        {
            this.ders_adi = _ders_adi;
            this.ders_kodu = _ders_kodu;
        }

        
    }
}
