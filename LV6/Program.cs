using System;


namespace LV6
{
    class Program
    {
        public class Trokut
        {
            public int a, b, c;


            public  Trokut()
            {
                a = 3;
                b = 4;
                c = 5;                                    
            }

            public Trokut(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                
            }

            public int Opseg()
            {
                return a + b + c;
                
                
                

            }

            public int Povrsina()
            {
                int pov = (a + b + c) / 2;
                return (int)Math.Sqrt(pov * (pov - a) * (pov - b) * (pov - c));
                
                

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
            Trokut br2 = new Trokut(4,4,4);

            Console.WriteLine("Opseg prvog trokuta: " + br1.Opseg() + " Opseg drugog trokuta: " + br2.Opseg());
            Console.WriteLine("Površina prvog trokuta: " + br1.Povrsina() + " Površina drugog trokuta: " + br2.Povrsina());







           






        }
    }
}



//using System;


//namespace LV6
//{
//    class Program
//    {
        
       

//        static void Main(string[] args)
//        {
//            Trokut br1 = new Trokut();
//            Console.WriteLine("")

//            Console.WriteLine("Opseg prvog trokuta: " + br1.Opseg());
//            Console.WriteLine("Površina prvog trokuta: " + br1.Povrsina());
 














//        }

//        class Trokut
//        {
//            public int a, b, c;
//            public Trokut()
//            {
//                a = 3;
//                b = 4;
//                c = 5;


//            }

//            public Trokut(int a, int b, int c)
//            {
//                this.a = a;
//                this.b = b;
//                this.c = c;
//            }

//            public int Opseg()
//            {
//                return a + b + c;

//            }

//            public int Povrsina()
//            {
//                int pov = (a + b + c) / 2;
//                return (int)Math.Sqrt(pov * (pov - a) * (pov - b) * (pov - c));

//            }

//            public void Greska()
//            {
//                Console.WriteLine("Stranice ne čine trokut");
//            }
//        }
//    }

//}
