using System;

namespace veri_yapıları_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive Fonk : Kendi içerisinde kendisini çağıran / tetikleyen fonksiyonlardır.
            // Özyinelemeli / Tekrarlamalı Fonk.

            // Recursive fonk. bir yaklaşımdır.

            // Recursive fonk. ne amaçla kullanılmaktadır ? 
            // Öngörülemeyen, derinliği tahmin edilemeyen, sonu bilinmeyen durumlarda tercih edilebilir.

            #region Örnek 1

            // Belirli değer aralığındaki 5'in katı olan tüm sayıları toplayan rec. fonk. yazalım

            // Döngüyle çözümü 
            /*
            int s1 = 100, s2 = 200;
            for (int i = s1; i < s2; i += 5)
            { 
                 ......
            }
             */

            Console.WriteLine(Topla(10, 20)); // 10+15+20 = 45

            int Topla( int baslangic, int bitis)
            {
                if(baslangic % 5 == 0)
                {
                    return baslangic + Topla(++baslangic, bitis);
                }
                if(baslangic < bitis)
                {
                    return Topla(++baslangic, bitis);
                }
                return 0;
            }

            #endregion

        }
    }
}
