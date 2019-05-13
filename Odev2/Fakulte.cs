using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Fakulte
    {
        private string fakulte_isim;
        private List<Bolum> bolum;

        public string Fakulte_isim { get => fakulte_isim; set => fakulte_isim = value; }
        internal List<Bolum> Bolum { get => bolum; set => bolum = value; }

        public Fakulte(string _fakulte_isim)
        {
            this.fakulte_isim = _fakulte_isim;
            bolum = new List<Bolum>();

        }
        public void Yeni_Bolum_Ac(Bolum b)
        {
            try
            {
                bolum.Add(b);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Açılmak istenen bölüm zaten bulunmakta.");

            }
        }
        public void Bolum_Kapat(Bolum b)
        {
            try
            {
                bolum.Remove(b);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Kapatılmak istenen bölüm bulunamadı."); ;
            }
        }
    }
}
