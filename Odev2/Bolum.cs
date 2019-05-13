using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Bolum
    {
        //proppertiler..
        private string bolum_isim;
        private string bolum_no;
        private List<Ogrenci> ogrenci;
        private List<Ogretim_Elemani> ogretim_elemani;
        private List<Ders> ders;

        public string Bolum_isim { get => bolum_isim; set => bolum_isim = value; }
        public List<Ders> Ders { get => ders; set => ders = value; }
        public List<Ogretim_Elemani> Ogretim_elemani { get => ogretim_elemani; set => ogretim_elemani = value; }
        public List<Ogrenci> Ogrenci { get => ogrenci; set => ogrenci = value; }
        public string Bolum_no { get => bolum_no; set => bolum_no = value; }

        public Bolum(string _bolum_isim,string _bolum_no)//consturctor..
        {
            this.bolum_isim = _bolum_isim;
            this.Bolum_no = _bolum_no;
            ogretim_elemani = new List<Ogretim_Elemani>();
            ders = new List<Ders>();
            Ogrenci = new List<Ogrenci>();
        }

        public void Yeni_Ders_Ekle(Ders d)
        {

            try
            {
                ders.Add(d);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Eklenecek ders zaten bulunmakta.");

            }
        }
        public void Ders_Kaldir(Ders d)
        {
            try
            {
                ders.Remove(d);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Kaldirilmak istenen ders zaten bulunmamakta.");
            }
        }
        public void Ogretim_Elemani_Ata(Ogretim_Elemani o_e)
        {
            try
            {
                ogretim_elemani.Add(o_e);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Atanacak olan öğretim elemanı zaten bulunmakta.");
            }
        }
        public void Ogretim_Elemani_Sil(Ogretim_Elemani o_e)
        {
            try
            {
                ogretim_elemani.Remove(o_e);    
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Silinecek olan öğretim elemanı zaten bulunmamakta.");

            }
        }
        //3 tip öğrenci olduğundan switch case kullandım..
        public void Ogrenci_Ekle( string ogr_ad,string ogr_soyad,string ogr_bolum,int ogr_no,int ogr_sube,string ogr_seviye)
        {
            try
            {
                Ogrenci _ogr = null;
                switch (ogr_seviye)
                {
                    case "Lisans Öğrencisi":
                        _ogr = new Lisans_Ogrencisi(ogr_ad, ogr_soyad, ogr_bolum, ogr_no, ogr_sube);
                        break;
                    case "YukesekLisans Öğrencisi":
                        _ogr = new Yukseklisans_Ogrencisi(ogr_ad, ogr_soyad, ogr_bolum, ogr_no, ogr_sube);
                        break;
                    case "Doktora Öğrencisi":
                        _ogr = new Doktora_Ogrencisi(ogr_ad, ogr_soyad, ogr_bolum, ogr_no, ogr_sube);
                        break;
                    
                       
                }
                ogrenci.Add(_ogr);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Eklenecek öğrenci zaten mevcut.");
            }
        }

        public void Ogrenci_Sil(Ogrenci no)
        {
            try
            {
                ogrenci.Remove(no);
            }
            catch (ArgumentException)
            {

                throw new ArgumentException("Silinecek Öğrenci bulunamadı.");
            }
           
        }
        public Ogrenci Ogrenci_Ara(string _isim)
        {
            Ogrenci s = null;
            foreach (Ogrenci a in ogrenci)//öğrenci listesini dolaşıyor...
            {
                if (String.Equals(a.Ogrenci_adi, _isim))//aradğımız isme uyan öğrenci var mı..
                {
                    s = a;
                    break;
                }
            }
            if (s == null)
            {
                throw new Ogrenci_Bulunamadi(_isim);
            }
            return s;
        }


        public Ogrenci Ogrenci_Ara(int _num)//aradğımız numaraya uyan öğrenci var mı..
        {
            Ogrenci s = null;
            foreach (Ogrenci a in ogrenci)
            {
                if (a.Ogrenci_no == _num)
                {
                    s = a;
                }
            }
            if (s == null) throw new Ogrenci_Bulunamadi(_num);
            return s;
        }
    }
}
