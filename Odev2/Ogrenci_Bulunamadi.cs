using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Ogrenci_Bulunamadi:Exception
    {
        public Ogrenci_Bulunamadi() : base()
        {

        }
        public Ogrenci_Bulunamadi(string isim):base($"{isim} adlı öğrenci bulunamadı.")
        {

        }
        public Ogrenci_Bulunamadi(int num):base($"{num} numaralı öğrenci bulunamadı.")
        {

        }
    }
}
