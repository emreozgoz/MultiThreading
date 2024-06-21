using System.Threading;
using System;
using System.Diagnostics;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Restoran Mesaisi Başlacı");
            //Menümüzde 4 adet yemeğimiz ve her bir yemekte uzmanlaşmış 4 aşçımız bulunmaktadır.
            //Mercimek Çorbası - Ahmet Usta
            //Ispanaklı Börek - Mehmet Usta
            //Köfte Patates - Emre Usta
            //Sütlaç - Ayşe Usta

            Thread corba = new Thread(MercimekÇorbasıYap)
            {
                Name = "AhmetUsta"
            };
            Thread borek = new Thread(BorekYap)
            {
                Name = "MehmetUsta"
            };
            Thread kofte = new Thread(KoftePatatesYap)
            {
                Name = "EmreUsta"
            };
            Thread sutlac = new Thread(SutlacYap)
            {
                Name = "AyşeUsta"
            };

            //yemekleri yapmaya başlayalım
            corba.Start();
            borek.Start();
            kofte.Start();
            sutlac.Start();
            Console.Read();
        }
        static void MercimekÇorbasıYap()
        {
            Console.WriteLine("Mercimek Çorbası yapılmaya başlandı " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Mercimek :" + i);
            }
            Console.WriteLine("Mercimek çorbası sunuma hazır " + Thread.CurrentThread.Name);
        }

        static void BorekYap()
        {
            Console.WriteLine("Börek Yapılmaya Başlandı" + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("BorekYap :" + i);
            }
            Console.WriteLine("Börek Sunuma Hazır " + Thread.CurrentThread.Name);
        }

        static void KoftePatatesYap()
        {
            Console.WriteLine("Patates Kızartılmaya Başladı " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Köfte Patates :" + i);
                if (i == 4)
                {
                    Console.WriteLine("Köfte Pişirilmeye Başlandı");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Köfteler Pişti");
                }
            }
            Console.WriteLine("Köfte ve Patatesler Sunuma Hazır " + Thread.CurrentThread.Name);
        }
        static void SutlacYap()
        {
            Console.WriteLine("Sütlaç Yapılmaya Başlandı " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("SutlacYap :" + i);
            }
            Console.WriteLine("Sütlaç Yapımı bitti " + Thread.CurrentThread.Name);
        }
    }
}