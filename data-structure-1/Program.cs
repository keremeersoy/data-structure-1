using System;

namespace data_structure_1
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] x = new int[10];
            int[,] y = new int[2, 3]; //iki boyutlu dizi
            int[,,] z = new int[2, 3, 4];//2 satır, 3'e bölünmüş, 4
                                         //z[0,1,2]
                                         //z[b1, b2, b3] --> new int[2,3,4]
                                         //z[i1, i2, i3] --> z[1,1,1] -> b2*b3*i1, i2*b3, i3*4 ADRES
            int[,,,] q = new int[4, 4, 2, 4]; //4 grup var, her bir dörtlü 4e ayrılmış, her bir dörtlü grup 2 ye bölünmüş. her bir ikili grup 4e bölünmüş.
            int[,,,] kku = new int[8, 10, 2, 4];
            //müh fak.     bilg müh nö.    1.sınıf    100
            //müh fak.     bilg müh nö.    2.sınıf    120
            // kku[b1, b2, b3, b4]
            // kku[i1, i2, i3, i4] adresi nedir?
            //toplam + (i1*b2*b3*b4 + i2*b3*b4 + i3*b4 + i4)*4
            //en fazla 1.sınıf hangi bölümde?
            //birinci sınıflarda en çok hangi fakültede öğrenci var?
            kku[0, 0, 0, 1] = 120;
            int toplam = 0;
            int ebb = 0;
            int fakulteindis = -1;

            for (int fak = 0; fak < 8; fak++)
            {
                for (int n_i = 0; n_i < 10; n_i++)
                {
                    for (int sin = 0; sin < 2; sin++)
                    {
                        toplam += kku[fak, n_i, sin];
                    }
                    if (ebb < toplam)
                    {
                        ebb = toplam;
                        fakulteindis = fak;
                    }

                }
            }

            //recursive yapı;
            // #tek boyutlu halini ise finalde sorucam:)
            // ikinci sınıfları 1.sınıflardan fazla olan
            // en fazla öprencisi olan 2. fakülte



            y[1, 0] = 8;

            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    toplam += y[j, i];
                }
            }

            // y[i1, i2] = y[1,1] = Başlangıç adresi + i1* satır boyutu + i2*4
            // her bir hücre 4byte
            // x[0]  1000. byte dan başlıyor
            // x[indis] = x[0] adres + indis*4
            // x[5] = 5*4 + 1000;

            x[9] = 9;
            if (int i = 0; i < 0; i++)
    {
                x[i] = i;
            }


            string s = "";
            s = "abc";
            s = "123";
            int a = 1;
            int b = 0;
            b = min(1, 2, 3);
            if (a > b) a = b;
            else b = a;
            Console.WriteLine(a);

            //değişkenlerin ram de saklandığı alanlar vardır
            //değişkenler ram'de yan yanadır. arada boşluklar olmaz.
            //string az kulllanıcaz çünkü performans düşmanı!!!!!!pointerdır

        }
        static int min {int a, int b, int c}

}
}
