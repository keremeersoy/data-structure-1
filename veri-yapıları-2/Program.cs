using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapıları_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Listemiz tydl = new Listemiz();
            int secim = menu();
            int sayi, indis;

            while( secim != 0) {
                switch( secim)
                {
                    case 1:
                        Console.Write("sayı : ");
                        sayi = int.Parse(Console.ReadLine());
                        tydl.basaEkle(sayi);
                        break;

                    case 2:
                        Console.Write("sayı : ");
                        sayi = int.Parse(Console.ReadLine());
                        tydl.sonaEkle(sayi);
                        break;

                    case 3:
                        Console.Write("indis : ");
                        indis = int.Parse(Console.ReadLine());
                        Console.Write("sayı : ");
                        sayi = int.Parse(Console.ReadLine());
                        tydl.arayaEkle(indis,sayi);
                        break;

                    case 4:
                        tydl.bastanSil();
                        break;

                    case 5:
                        tydl.sondanSil();
                        break;

                    case 6:
                        Console.Write("indis : ");
                        indis = int.Parse(Console.ReadLine());
                        tydl.aradanSil(indis);
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("hatalı seçim yaptınız ! ");
                        break;
                }
                Console.Clear();
                tydl.yazdir();
                tydl.elemanSay();
                secim = menu();
            }
        }

        private static int menu()
        {
            int secim;
            Console.WriteLine("1 - başa ekle ");
            Console.WriteLine("2 - sona ekle ");
            Console.WriteLine("3 - araya ekle ");
            Console.WriteLine("4 - baştan sil ");
            Console.WriteLine("5 - sondan sil ");
            Console.WriteLine("6 - aradan sil ");
            Console.WriteLine("0 - programı kapat ");
            Console.Write("seçiminiz : ");
            secim = int.Parse(Console.ReadLine());
            return secim;


        }

    }

    class Node
    {
        public int data;
        public Node next;
        public Node( int data)
        {
            this.data = data;
            next = null;
        }
    }

    class Listemiz
    {
        Node head; // listenin başındaki düğüm
        public Listemiz()
        {
            head = null;
        }

        public void basaEkle( int data)
        {
            Node eleman = new Node(data);
            if (head == null)
            {
                head = eleman;
            }
            else
            {
                eleman.next = head;
                head = eleman;
            }
        }

        public void sonaEkle( int data)
        {
            Node eleman = new Node(data);
            if ( head == null)
            {
                head = eleman;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = eleman;
            }
        }

        public void arayaEkle( int indis, int data)
        {
            Node eleman = new Node(data);
            bool sonuc = false;

            if ( head == null && indis == 0)
            {
                head = eleman;
                sonuc = true;
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;

                while ( temp.next != null)
                {
                    if (  i == indis )
                    {
                        sonuc = true;
                        temp2.next = eleman;
                        eleman.next = temp;
                        Console.WriteLine("Araya eleman eklendi !");
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
                    eleman.next = temp;
                    Console.WriteLine("Araya eleman eklendi !");
                }
            }
            if ( sonuc == false)
            {
                Console.WriteLine("Hatalı indis seçimi yaptınız !");
            }
        }

        public void bastanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste Boş");
            }
            else if ( head.next == null)
            {
                head = null;
                Console.WriteLine("Listede kalan son elemanı da sildiniz !");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Baştan eleman silindi !");
            }
        }

        public void sondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste Boş");
            }
            else if (head.next == null)
            {
                head = null;
                Console.WriteLine("Listede kalan son elemanı da sildiniz !");
            }
            else
            {
                Node temp = head;
                Node temp2 = temp;

                while( temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }

                temp2.next = null;
                Console.WriteLine("Sondan eleman silindi !");
            }

        }

        public void aradanSil(int indis)
        {
            bool sonuc = false;
            if (head == null)
            {
                sonuc = true;
                Console.WriteLine("Liste boş !");
            }
            else if ( head.next == null && indis == 0)
            {
                sonuc = true;
                head = null;
                Console.WriteLine("Listede kalan son elemanı sildiniz !");
            }
            else if ( head.next != null && indis == 0)
            {
                sonuc = true;
                bastanSil();
                Console.WriteLine("Eleman silindi !");
            }
            else
            {
                int i = 0;

                Node temp = head;
                Node temp2 = temp;

                while ( temp.next != null)
                {
                    if ( i == indis)
                    {
                        sonuc = true;
                        temp2.next = temp.next;
                        Console.WriteLine("Aradan eleman silindi !");
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == indis)
                {
                    //sondanSil();

                    sonuc = true;
                    temp2.next = null;
                    Console.WriteLine("Aradan eleman silindi !");
                    i++;
                    
                }
            }

            if(sonuc == false)
            {
                Console.WriteLine("Hatalı bir indis girdiniz !");
            }
        }

        public void yazdir()
        {
            if (head == null)
            {
                Console.WriteLine("Liste Boş");
            }
            else
            {
                Node temp = head;
                Console.Write("Baş -> ");

                while(temp.next != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data + " Son.");
            }
        }

        public void elemanSay()
        {
            int sayac = 0;
            if(head == null)
            {
                Console.WriteLine("Eleman sayısı : " + sayac);
            }
            else
            {
                Node temp = head;

                while ( temp.next != null)
                {
                    sayac++;
                    temp = temp.next;
                }
                sayac++;
                Console.WriteLine("Eleman sayısı : " + sayac);
            }
        }
    }

    
}
