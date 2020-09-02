using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForeachandGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Ad = "IPhone";
            urun1.Aciklama = "Apple";
            urun1.StokDurum = 5;

            Urun urun2 = new Urun();
            urun2.Ad = "Huawei";
            urun2.Aciklama = "Çin malı";
            urun2.StokDurum = 3;


            List<Urun> urunler = new List<Urun>();
            urunler.Add(urun1);
            urunler.Add(urun2);


            //Ekrana urunlerin adını yazdır

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Ad);
            }

            Console.ReadLine();



            List<string> data = new List<string>();
            
            data.Add("Çağatay");
            data.Add("Berk");
            data.Add("Metin");

            //data[1] = "Mustafa";

        }
    }
}
