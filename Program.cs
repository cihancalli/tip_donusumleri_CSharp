using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit  Conversion *****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: "+d);

            long h = d;
            Console.WriteLine("h: "+h);

            float i = h;
            Console.WriteLine("i: "+i);

            string e = "Cihan";
            char f = 'C';

            object g = e+f+d;
            Console.WriteLine("g: "+g);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("");
            Console.WriteLine("***** Explicit Conversion *****");

            int x= 4;
            byte y = (byte)x;
            Console.WriteLine("y: "+y);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: "+ v);

            // *** ToString Methodu ***
            Console.WriteLine("");
            Console.WriteLine("***** ToString Methodu *****");

            int xx = 6;
            string yy =xx.ToString();
            Console.WriteLine("yy: "+ yy);


            string zz = 12.5f.ToString();
            Console.WriteLine("zz: "+ zz);

            // *** System.Convert Sınıfı ***
            Console.WriteLine("");
            Console.WriteLine("***** System.Convert Sınıfı *****");

            string s1 = "10" ,s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+ Toplam);

            //Parse 
            Console.WriteLine("");
            Console.WriteLine("***** Parse Methodu *****");
            //String ifadelerini dönüştürmel için ve her zaman strin alır 

            ParseMethod();


            Console.WriteLine("");
            Console.WriteLine("");

            string date = "01.04.1991";
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine("dt: "+ dt);
            DateTime dt2 = DateTime.Parse(date);
            Console.WriteLine("dt2: "+ dt2);

            //Aşağıdaki tip dönüşümlerinden hangisini explicit dahi olsa gerçekleştiremeyiz?
            //string -> byte

            //0-255 aralığında nümerik bilgi barındıran string tipindeki bir değişkenin dönüşümü için aşağıdakilerden hangisi kullanılamaz?
            //sbyte.Parse()

            //https://github.com/cihancalli/Conversion_CSharp_HackerRank.git
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 =  "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: "+ rakam1);

            double1 = Double.Parse(metin2);
            Console.WriteLine("double1: "+ double1);
        }
    }
}
