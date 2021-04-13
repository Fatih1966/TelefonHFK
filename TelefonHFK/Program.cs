using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace TelefonHFK
{
    class Program
    {

        static void Main(string[] args)
        {

            Telefon telefon = new Telefon();

            //Iphone için
            //constructor'daki default değerler
            Console.WriteLine("Markası\t:\t" + telefon.Marka);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tipi\t:\t" + telefon.Tip);
            Console.WriteLine("İsl.Sis\t:\t"+telefon.IsletimSistemi);
            Console.WriteLine("Yılı\t:\t" + telefon.ModelYili);
            //bu telefonun özel değerleri atanıyor
            telefon.Ekran = ekran.Besbucukinch;
            Console.WriteLine("Ekran\t:\t"+telefon.Ekran);
            //fiyat değeri kontrol edildikten sonra yazdırılıyor.
            Console.WriteLine("Fiyatı\t:\t"+telefon.Fiyat);

        }
    }
}
