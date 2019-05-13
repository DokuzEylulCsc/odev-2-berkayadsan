using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
   abstract class Ogrenci
   {
        protected string ogrenci_adi;
        protected string ogrenci_soyadi;
        protected string ogrenci_bolumu;
        protected int ogrenci_sube;
        protected int ogrenci_no;

        public string Ogrenci_adi { get => ogrenci_adi;  }
        public string Ogrenci_soyadi { get => ogrenci_soyadi;  }
        public int Ogrenci_no { get => ogrenci_no;  }
        public int Ogrenci_sube { get => ogrenci_sube; set => ogrenci_sube = value; }

        public Ogrenci(string _ogrenci_adi,string _ogrenci_soyadi,string _ogrenci_bolum,int _ogrenci_numarasi,int _ogrenci_sube)
        {
            this.ogrenci_adi = _ogrenci_adi;
            this.ogrenci_soyadi = _ogrenci_soyadi;
            this.ogrenci_bolumu = _ogrenci_bolum;
            this.ogrenci_no = _ogrenci_numarasi;
            this.ogrenci_sube = _ogrenci_sube;
            
        }
    }
}
