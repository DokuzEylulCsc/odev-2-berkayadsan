using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Ogretim_Elemani
    {
        private string ogretim_el_adi;
        private string ogretim_el_soyadi;
        
        private string ogretim_el_bolum;
        private List<Ders> ogretim_elemani_ders;

        public string Ogretim_el_adi { get => ogretim_el_adi; set => ogretim_el_adi = value; }
        public string Ogretim_el_soyadi { get => ogretim_el_soyadi; set => ogretim_el_soyadi = value; }
        
        public List<Ders> Ogretim_elemani_ders { get => ogretim_elemani_ders; set => ogretim_elemani_ders = value; }
        public string Ogretim_el_bolum { get => ogretim_el_bolum; set => ogretim_el_bolum = value; }

        public Ogretim_Elemani(string _ogretim_el_adi, string _ogretim_el_soyadi, string _ogretim_el_bolum)
        {
            this.ogretim_el_adi = _ogretim_el_adi;
            this.ogretim_el_soyadi = _ogretim_el_soyadi;
            this.ogretim_el_bolum = _ogretim_el_bolum;
            
            ogretim_elemani_ders = new List<Ders>();
        }

        public void Ogretim_Elemani_Ders_Ata(Ders _d)
        {
            try
            {
                ogretim_elemani_ders.Add(_d);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Öğretim elemanına verilecek ders zaten o elemana ait.");
            }
        }
        public void Ogretim_Elemani_Ders_Sil(Ders _d)
        {
            try
            {
                ogretim_elemani_ders.Remove(_d);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Öğretim elemanından silinecek olan ders zaten bulunmamakta.");

            }
        }
    }
}
