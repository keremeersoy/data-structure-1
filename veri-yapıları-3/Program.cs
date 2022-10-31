using System;

namespace veri_yapıları_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÇİFT YÖN LİSTELER

            Liste ciftYonListe = new Liste();

            ciftYonListe.basaEkle(10);
            ciftYonListe.basaEkle(20);
            ciftYonListe.basaEkle(30);
            ciftYonListe.basaEkle(40);
            ciftYonListe.sonaEkle(0);
            
            ciftYonListe.terstenYazdir();
            ciftYonListe.yazdir();

            ciftYonListe.bastanSil();
            ciftYonListe.yazdir();

            ciftYonListe.sondanSil();
            ciftYonListe.yazdir();

            ciftYonListe.arayaEkle(1,50);
            ciftYonListe.yazdir();

            ciftYonListe.sonaEkle(60);
            ciftYonListe.sonaEkle(70);
            ciftYonListe.sonaEkle(80);

            ciftYonListe.yazdir();

            ciftYonListe.aradanSil(4);

            ciftYonListe.yazdir();



            Console.ReadLine();
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }

    }

    class Liste
    {
        Node head;
        Node tail; // son düğüme tail deniyor

        public Liste()
        {
            head = null;
            tail = null;
        }

        public void basaEkle(int data)
        {
            Node eleman = new Node(data);

            if( head == null)
            {
                head = tail = eleman;
                Console.WriteLine("Liste oluşturuldu , ilk eleman eklendi ! ");
            }
            else
            {
                eleman.next = head;
                head.prev = eleman;
                head = eleman;
                Console.WriteLine("Listenin başına eleman eklendi ! ");
            }
        }

        public void sonaEkle(int data)
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = tail = eleman;
                Console.WriteLine("Liste oluşturuldu , ilk eleman eklendi ! ");
            }
            else
            {
                tail.next = eleman;
                eleman.prev = tail;
                tail = eleman;
                Console.WriteLine("Listenin sonuna eleman eklendi ! ");
            }
        }

        public void arayaEkle(int indis, int data)
        {
            bool sonuc = false;
            Node eleman = new Node(data);

            if(head == null && indis == 0)
            {
                sonuc = true;
                head = tail = eleman;
                Console.WriteLine("Liste oluşturuldu , ilk eleman eklendi ! ");
            }
            else if( head != null && indis == 0)
            {
                sonuc = true;
                basaEkle(data);
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;

                while (temp.next != null)
                {
                    if( i == indis)
                    {
                        sonuc = true;
                        temp2.next = eleman;
                        eleman.prev = temp2;

                        eleman.next = temp;
                        temp.prev = eleman;
                        Console.WriteLine("Araya eklendi ! ");
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if( i == indis)
                {
                    sonuc = true;
                    temp2.next = eleman;
                    eleman.prev = temp2;

                    eleman.next = tail;
                    tail.prev = eleman;
                    Console.WriteLine("Araya eleman eklendi ! ");
                }
            }

            if(sonuc == false)
            {
                Console.WriteLine("Hatalı indis seçimi");
            }
        }

        public void yazdir()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş ! ");
            }
            else
            {
                Node temp = head;
                Console.Write("Baş -> ");

                while( temp.next != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data + " son ! ");
            }
        }

        public void terstenYazdir()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş ! ");
            }
            else
            {
                Node temp = tail;
                Console.Write("Son -> ");

                while (temp.prev != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.prev;
                }
                Console.WriteLine(temp.data + " Baş ! ");
            }
        }

        public void bastanSil()
        {
             if (head == null)
            {
                Console.WriteLine("Liste boş ! ");
            }
            else if ( head.next == null)
            {
                head = tail = null;
                Console.WriteLine("Listede kalan son düğüm silindi ! ");
            }
             else
            {
                head = head.next;
                head.prev = null;
                Console.WriteLine("Baştan eleman silindi ! ");
            }
        }

        public void sondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş ! ");
            }
            else if (head.next == null)
            {
                head = tail = null;
                Console.WriteLine("Listede kalan son düğüm silindi ! ");
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
                Console.WriteLine("Sondan eleman silindi ! ");
            }
        }

        public void aradanSil(int indis)
        {
            if( head == null)
            {
                Console.WriteLine("Liste boş ! ");
            }
            else if(head.next == null && indis == 0)
            {
                head = tail = null;
                Console.WriteLine("Listede kalan son düğüm silindi !");
            }
            else if (head.next != null && indis == 0)
            {
                bastanSil();
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;

                while(temp.next != null)
                {
                    if( i == indis)
                    {
                        temp2.next = temp.next;
                        temp.next.prev = temp2;
                        Console.WriteLine("Aradan düğüm silindi ! ");
                        i++;
                        break;
                    }

                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }

                if( i == indis)
                {
                    sondanSil();
                }
            }
        }

    }
}
