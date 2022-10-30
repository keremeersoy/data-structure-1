using System;

namespace veri_yapıları_1
{
    class Node
    {
        public int data;
        public Node next;

        public Node ( int data )
        {
            this.data = data;
            next = null;
        }
    }

    class List
    {
        Node head;

        public List()
        {
            head = null;
        }

        public void sonaEkle ( int data )
        {
            Node eleman = new Node(data);

            if ( head == null )
            {
                head = eleman;
                Console.WriteLine("liste oluşturuldu, ilk düğüm eklendi");
            }
            else
            {
                Node temp = head;

                while ( temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = eleman;
                Console.WriteLine("sona eleman eklendi");
            }
        }

        public void basaEkle ( int data )
        {
            Node eleman = new Node(data);

            if( head == null )
            {
                head = eleman;
                Console.WriteLine("liste oluşturuldu, ilk eleman eklendi");
            }
            else
            {
                eleman.next = head; // listenin başına eleman eklendi
                head = eleman;   // eklenen düğümümn ismi head oldu

                Console.WriteLine("başa eleman eklendi");
            }
        }

       public void yazdir()
        {
            Node temp = head;

            if( head == null)
            {
                Console.WriteLine("liste boş");
            }
            else
            {
                Console.Write(" baş ");
                while( temp.next != null)
                {
                    Console.Write( temp.data + " -> ");
                    temp = temp.next;
                }
                Console.Write(temp.data + " son ");

            }
        }

        public void bastanSil()
        {
            if ( head == null)
            {
                Console.WriteLine("liste boş");
            }
            else
            {
                head = head.next; // baştaki düğümü sildik
                Console.WriteLine("baştan eleman silindi");
            }
        }

        public void sondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("liste boş");
            }
            else if ( head.next == null)
            {
                head = null;
                Console.WriteLine("listede kalan son düğüm de silindi");
            }
            else
            {
                Node temp = head;                   // temp baştan başlayıp en sondaki düğüme kadar gidecek olan
                Node temp2 = temp;                  // temp2 ise sondan bi önceki düğümü tutmak için olan
                
                while( temp.next != null )          //en sondaki düğüme gelene kadar olan süreç bu while
                {
                    temp2 = temp;                   //temp önden gidiyor temp2 hep bi arkasındaki düğümü tutuyor
                    temp = temp.next;               // temp ilerliyor
                }

                // whiledan çıktık yani temp şu an en son düğümde, temp2 ondan bi önceki düğümde

                temp2.next = null;                  // temp2 (sondan bi önceki) düğümünün pointerını (nexti) null olarak aticaz ki en sondaki düğümle yani temple ilişkisi kesilsin
                Console.WriteLine("sondaki düğüm silindi");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            List tekYonListe = new List();

            int secim = menu();

            while ( secim != 0)
            {
                switch ( secim)
                {
                    case 1:
                        Console.Write("sayı : ");
                        sayi = int.Parse(Console.ReadLine());
                        tekYonListe.basaEkle(sayi);
                        break;

                    case 2:
                        Console.Write("sayı : ");
                        sayi = int.Parse(Console.ReadLine());
                        tekYonListe.sonaEkle(sayi);
                        break;

                    case 3:
                        tekYonListe.bastanSil();
                        break;

                    case 4:
                        tekYonListe.sondanSil();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("hatalı seçim yaptınız");
                        break;
                }

                tekYonListe.yazdir();
                Console.WriteLine();
                secim = menu();

            }
            Console.ReadKey();

            //tekYonListe.sonaEkle(10);
            //tekYonListe.sonaEkle(20);
            //tekYonListe.sonaEkle(30);

            //tekYonListe.yazdir();
            //Console.WriteLine();

            //tekYonListe.basaEkle(5);
            //tekYonListe.sonaEkle(100);

            //tekYonListe.yazdir();

            //Console.WriteLine();

            //tekYonListe.bastanSil();
            //tekYonListe.bastanSil();

            //tekYonListe.yazdir();
            //Console.WriteLine();

            //tekYonListe.sondanSil();
            //tekYonListe.yazdir();

            //Console.ReadKey();
        }
        private static int menu()
        {
            int secim;
            Console.WriteLine("1 - başa ekle");
            Console.WriteLine("2 - sona ekle");
            Console.WriteLine("3 - baştan sil");
            Console.WriteLine("4 - sondan sil");
            Console.WriteLine("0 - programı kapat");
            Console.Write("seçiminiz : ");
            secim = int.Parse(Console.ReadLine());
            return secim;


        }
    }
}
