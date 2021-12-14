using System;

namespace LV6
{
    class Program
    {
        public class Trokut
        {
            public int a1,a2,a3;
            public int b1, b2, b3;


            public void Konstruktor1(int a=3, int b=4, int c=5)
            {
                a1 = a;
                a2 = b;
                a3 = c;                                    
            }

            public void Konstruktor2(int a, int b, int c)
            {
                b1 = a;
                b2 = b;
                b3 = c;
            }

            public void Opseg()
            {
                int opseg1 = a1 + a2 + a3;
                int opseg2 = b1 + b2 + b3;
                Console.WriteLine("Opseg prvog trokuta je {0}, a drugog je {1}",opseg1,opseg2);
                

            }

            public void Povrsina()
            {
                int povrsina1 = a1 * a2 * a3;
                int povrsina2 = b1 * b2 * b3;
                Console.WriteLine("Povrsina prvog trokuta je {0}, a drugog je {1}", povrsina1, povrsina2);

            }



        }
        public void Upozorenje()
        {
            Console.WriteLine("Stranice ne čine trokut");
        }

        static void Main(string[] args)
        {
            int a, b, c;

            Trokut br1 = new Trokut();
            Trokut br2 = new Trokut();

            br1.Konstruktor1();
            br1.Konstruktor2(4,4,4);

            br1.Opseg();
            br1.Povrsina();

            Console.WriteLine("Unesite stranice trokuta");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            br2.Konstruktor1();
            br2.Konstruktor2(a, b, c);

            br2.Opseg();
            br2.Povrsina();






        }
    }
}
