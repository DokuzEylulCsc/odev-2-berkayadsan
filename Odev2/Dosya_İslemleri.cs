using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Odev2
{
    class Dosya_İslemleri
    {
       public void Dosyaya_Yazma(Ders _derss)
        {
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"desktop:\dosya.txt"))
            {
                dosya.WriteLine("{0} {1} {2}", _derss.Ders_adi, _derss.Ders_kodu, DateTime.Today);
                dosya.WriteLine("Öğrenci Listesi");

                foreach (Ogrenci t in _derss.ogrenci)
                {
                    dosya.WriteLine("Öğrenci adı:{0} , Öğrenci soyadı:{1}, Öğrenci numarası:{2}, Öğrenci bölüm:{3},Öğrenci şube:{4}",t.Ogrenci_adi,t.Ogrenci_soyadi,t.Ogrenci_no,t.Ogrenci_sube);     
                }

                foreach (Ogretim_Elemani t in _derss.ogretim_elemani)
                {
                    dosya.WriteLine("Öğretim elemanının adı :{0} ,soyadı :{1},bölümü :{2}}", t.Ogretim_el_adi, t.Ogretim_el_soyadi, t.Ogretim_el_bolum);
                }

                dosya.Flush();
                dosya.Close();
            }
        }


    }
}
