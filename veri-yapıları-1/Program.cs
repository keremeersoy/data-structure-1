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
            List tekYonListe = new List();

            tekYonListe.sonaEkle(10);
            tekYonListe.sonaEkle(20);
            tekYonListe.sonaEkle(30);

            tekYonListe.yazdir();
            Console.WriteLine();

            tekYonListe.basaEkle(5);
            tekYonListe.sonaEkle(100);

            tekYonListe.yazdir();

            Console.WriteLine();

            tekYonListe.bastanSil();
            tekYonListe.bastanSil();

            tekYonListe.yazdir();
            Console.WriteLine();

            tekYonListe.sondanSil();
            tekYonListe.yazdir();

            Console.ReadKey();
        }
    }
}
