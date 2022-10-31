using System;

namespace veri_yapıları_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // STACK YAPISI

            StackYapisi stc = new StackYapisi();

            stc.push(10);
            stc.push(20);
            stc.push(30);
            stc.push(40);

            stc.print();


            Console.ReadLine();
        }
    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class StackYapisi
    {
        Node top;

        public StackYapisi()
        {
            top = null;
        }

        public void push(int data)
        {
            Node eleman = new Node(data);
            if(top == null)
            {
                top = eleman;
                Console.WriteLine("Stack yapısı oluşturuldu , ilk eleman stack'e girdi");
            }
            else
            {
                eleman.next = top;
                top = eleman;
                Console.WriteLine("Eleman eklendi ! ");
            }
        }

        public int pop()
        {
            if ( top== null)
            {
                Console.WriteLine("Stack boş ! ");
                return -1;
            }
            else
            {
                int sayi = top.data;
                top = top.next;
                Console.WriteLine(sayi + " Stack'ten çıkartıldı ! ");
                return sayi;
            }
        }

        public void print()
        {
            if ( top == null)
            {
                Console.WriteLine("Stack boş ! ");
            }
            else
            {
                Node temp = top;
                //Console.Clear();

                while( temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

    }
}
