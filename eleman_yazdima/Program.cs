using System;

namespace eleman_yazdima
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("******************************");

            string[] isim = { "Aybike", "Beste", "Berika", "Tuğre", "Cenk" };
    
            
            {

                Console.WriteLine("isim:" + isim[0]);
                Console.WriteLine("isim:" + isim[1]);
                Console.WriteLine("isim:" + isim[2]);
                Console.WriteLine("isim:" + isim[3]);
                Console.WriteLine("isim:" + isim[4]);

                Console.WriteLine("=======================");
              
                foreach (string ad in isim)
             
                {
                    Console.WriteLine(ad);
                }
               



            }
            Console.ReadKey();
        }
    }
}
