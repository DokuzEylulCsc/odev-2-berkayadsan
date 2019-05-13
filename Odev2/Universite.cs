using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Universite
    {
        private string uni_isim;
        
        private List<Fakulte> fakulte;



        public string Uni_isim { get => uni_isim; set => uni_isim = value; }
       

        public Universite()
        {

        }
        public Universite(string _uni_isim)
        {
            this.uni_isim = _uni_isim;
           
            fakulte = new List<Fakulte>();
        }



        //public Ogrenci Ogrenci_Ara(string _isim)
        //{
        //    Ogrenci s = null;
        //    foreach (Ogrenci a in ogrenci)
        //    {
        //        if (String.Equals(a.Ogrenci_adi,_isim))
        //        {
        //            s = a;
        //            break;
        //        }
        //    }
        //    if (s==null)
        //    {
        //        throw new Ogrenci_Bulunamadi(_isim);
        //    }
        //    return s;
        //}

        //public Ogrenci Ogrenci_Ara(int _num)
        //{
        //    Ogrenci s = null;
        //    foreach (Ogrenci a in ogrenci)
        //    {
        //        if (a.Ogrenci_no==_num)
        //        {
        //            s = a;
        //        }
        //    }
        //    if (s == null) throw new Ogrenci_Bulunamadi(_num);
        //    return s;
        //}
        public void Fakulte_Ac(Fakulte f)
        {
            try
            {
                fakulte.Add(f);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Açılmak istenen fakülte zaten bulunmakta.");

            }
        }
    }
}
