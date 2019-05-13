using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Lisans_Ogrencisi:Ogrenci
    {
        public Lisans_Ogrencisi(string adi,string soyadi,string bolum,int no,int sube) : base(adi, soyadi, bolum, no,sube)
        {
            //base class kısmından alıyoruz.. Gövdeyi doldurmaya gerek yok..
        }
    }
}
