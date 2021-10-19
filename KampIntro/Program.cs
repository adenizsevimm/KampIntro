using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //"kategoriEtiketi"=Değer turucu,alias



            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisiYapmıisMi = false;
            double dolarDun = 9.19;
            double dolarBugun = 9.27;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }

            else
            {
                Console.WriteLine("Sabit oku");
            }




            if (sistemeGirisiYapmıisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
