using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Library
{

    public enum Tip
    {
        MasaUstu,
        Kablosuz,
        Arac,
        Cep,
        Uydu
    }

    public enum Marka
    {
        Samsung,
        IPhone,
        Huawei,
        Xiaomi,
        General_Mobile,
        LG,
        Vestel,
        Casper,
    }

    public enum IsletimSistemi
    {
        Android,
        Symbian,
        IOS,
        BlackBerryOS,
        Windows_Mobile,
        Bada,
        WebOS,
        Landline,
        Others
    }

    public enum ekran
    {
        Ekranyok,
        Ucbucukinch,
        Dortinch,
        Dortnoktayediinch,
        Besbucukinch,
    }

    public class Telefon
    {

        public Telefon()
        {
            ModelYili = DateTime.Now.Year;
            Tip = Tip.Cep;
            Marka = Marka.IPhone;
            IsletimSistemi = IsletimSistemi.IOS;
            Ekran = ekran.Dortinch;

        }

        public int ModelYili { get; set; }
        public Tip Tip { get; set; }
        public Marka Marka { get; set; }
        public IsletimSistemi IsletimSistemi { get; set; }
        public ekran Ekran { get; set; }

        private int fiyat = 2000;
        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                if (value>1500)
                    Fiyat = fiyat;
                else
                {
                    Console.WriteLine("Yanlış deger girdiniz");
                }
            }
        }
    }

    
}
