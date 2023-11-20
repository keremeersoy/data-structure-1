using System;

namespace veri_yapilari_2023_vize_notlarii
{
    internal class Program
    {
        //class Block
        //{
        //    public int data;
        //    public Block next;
        //    public Block prev;
        //}



        static void Main(string[] args)
        {
            int[] stack = new int[100];
            int sp = -1;

            void push(int data)
            {
                if (sp >= stack.Length) return;// stackımız alanından fazla veri atanıp patlamaması için önlem aldık
                sp++;
                stack[sp] = data;
            }

            int pop()
            {
                if (sp <= -1) return -1;//Yine stackta olmayan verileri çekip patlatmasın diye önlem aldık
                int tmp = stack[sp];
                sp--;
                return tmp;
            }

            bool hata = false;
            string st = "mum";
            for(int i = 0; i < st.Length; i++)
            {
                push(st[i]);
            }
            for(int i = 0; i < st.Length; i++)
            {
                if (st[i] != pop())
                {
                    hata = true;
                    break;
                }


            }

            if(hata)
            {
                Console.WriteLine("bu text palindromik degil!");
                return;
            }

            Console.WriteLine("palindromik text!");

        }
    }
}
