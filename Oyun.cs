using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    public class Oyun
    {
        public List<Futbolcu> Oyuncu1 { get; set; }
        public List<Futbolcu> Oyuncu2 { get; set; }

        int oyuncu1Skor = 0, oyuncu2Skor = 0;

        public Oyun()
        {
            Oyuncu1 = new List<Futbolcu> 
            {
                new Kaleci { Isim = "Mondragon" },
                new Defans() { Isim = "Popescu" },
                new Forvet() { Isim = "Messi" }
            };

            Oyuncu2 = new List<Futbolcu>
            {
                new Kaleci { Isim = "Tafarel" },
                new Defans() { Isim = "Roberto Carlos" },
                new Forvet() { Isim = "Ronaldo" }
            };
        }

        public void Oyna()
        {
            for (int i = 0; i < 6; i++)
            {
                if(i % 2 == 0)
                {
                    int sans = ((Forvet)(Oyuncu1[2])).SutCek();
                    bool kurtardiMi = ((ISansiOlanFutbolcu)(Oyuncu2[1])).SansHesapla(sans);
                    kurtardiMi = ((ISansiOlanFutbolcu)(Oyuncu2[0])).SansHesapla(sans);

                    if (kurtardiMi == false)
                        oyuncu1Skor++;
                }
                else
                {
                    int sans = ((Forvet)(Oyuncu2[2])).SutCek();
                    bool kurtardiMi = ((ISansiOlanFutbolcu)(Oyuncu1[1])).SansHesapla(sans);
                    kurtardiMi = ((ISansiOlanFutbolcu)(Oyuncu1[0])).SansHesapla(sans);

                    if (kurtardiMi == false)
                        oyuncu2Skor++;
                }
            }
        }

        public void SkorYazdir()
        {
            Console.WriteLine("İlk oyuncunun skoru: " + oyuncu1Skor);
            Console.WriteLine("İkinci oyuncunun skoru: " + oyuncu2Skor);
        }
    }
}
