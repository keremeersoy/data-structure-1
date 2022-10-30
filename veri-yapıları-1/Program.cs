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

            tekYonListe.basaEkle(5);
            tekYonListe.sonaEkle(100);

            tekYonListe.yazdir();

            Console.WriteLine();

            tekYonListe.bastanSil();
            tekYonListe.bastanSil();

            tekYonListe.yazdir();


            Console.ReadKey();
        }
    }
}
