using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            string universite_adi = "Dokuz Eylül Üniversitesi";
            Universite deu = new Universite(universite_adi);

            Fakulte fa = new Fakulte("Fen Fakultesi");
            fa.Yeni_Bolum_Ac(new Bolum("Bilgisayar Bilimleri","1"));
            fa.Yeni_Bolum_Ac(new Bolum("Fizik", "2"));
            fa.Bolum_Kapat(new Bolum("Fizik", "2"));

            Bolum b = new Bolum("Bilgisayar Bilimleri", "1");
            b.Ogrenci_Ara(5);
            b.Ogrenci_Ekle("Berkay", "Adsan", "Bilgisayar Bilimleri", 2, 1, "Lisans Öğrecisi");
            b.Ogretim_Elemani_Ata(new Ogretim_Elemani("Mert", "Kaya", "Bilgisayar Bilimleri"));

            b.Ogretim_Elemani_Sil(new Ogretim_Elemani("Mert", "Kaya", "Bilgisayar Bilimleri"));

        ////http://194.27.66.201/moodle/course/view.php?id=32
        ////https://www.youtube.com/watch?v=Ocwzh8w4MPo
        //https://www.c-sharpcorner.com/article/iterator-design-pattern/



        }
    }
}
