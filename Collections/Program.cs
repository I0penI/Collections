using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList (Tipten bağımsız Kolleksiyon)
            ArrayList liste = new ArrayList();
            liste.Add("Ali");
            liste.Add(27);
            liste.Add(true);
            liste.Add('Y');
            foreach(var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            #endregion

            #region List (Tip güvenli (Type safe) kolleksiyon)
            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Ali");
            ogrenciler.Add("Yağmur");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            List<int> sayilar = new List<int>()
            {
                1, 3, 5, 7, 9
            };
            
            
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine(sayilar.Sum());
            sayilar.Add(11);
            Console.WriteLine(sayilar.Sum());


            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir()
                {
                    Adi = "Ankara",
                    PlakaNo = 6
                },
                new Sehir()
                {
                    Adi = "Gaziantep",
                    PlakaNo = 27
                }
            };
            Sehir sehir = new Sehir()
            {
                PlakaNo = 34,
                Adi = "İstanbul"
            };
            sehirler.Add(sehir);
            sehirler.Add(new Sehir() { Adi = "Diyarbakır", PlakaNo = 21 });
            foreach (var sehirElemanı in sehirler)
            {
                Console.WriteLine(sehirElemanı.Adi + "(" + sehirElemanı.PlakaNo + ")");
            }
            #endregion
        }
        class Sehir // model
        {
            public byte PlakaNo { get; set; }
            public string Adi { get; set; }
        }
    }
}