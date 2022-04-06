            Console.WriteLine("Merhaba Sınıf");
            Console.Write("Algoritma ve Programlama Dersi");

            Console.ReadKey();
/*-----------------------------------------------------------------------------------------------------*/


            int sayi1 = 500, sayi2 = 150;

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            
	        Console.WriteLine("Sayi1'in değeri:"+sayi1);
            Console.WriteLine("Sayi2'nin değeri:" + sayi2);
/*-----------------------------------------------------------------------------------------------------*/

            int a = 500;
            double piSayisi = 3.14;
            float ortalama = 70.5f;
            string isim = "Recep";

            Console.WriteLine("a değişkeninin değeri:"+a);
            Console.WriteLine("pi sayısının değeri:"+piSayisi);
            Console.WriteLine("Ortalamanız:" + ortalama);
            Console.WriteLine("İsminiz:" + isim);

            Console.ReadKey();
/*-----------------------------------------------------------------------------------------------------*/

            int a=1500, b=850, toplam;
            toplam = a + b;

            Console.WriteLine("a değişkenini değeri:" + a);
            Console.WriteLine("b değişkeninin değeri:" + b);
            Console.WriteLine("Toplam:" + toplam);
/*-----------------------------------------------------------------------------------------------------*/

            int a, b, toplam;

            Console.Write("1.sayıyı girin:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı girin:");
            b = Convert.ToInt32(Console.ReadLine());

            toplam = a + b;

            Console.WriteLine("a sayısının değeri:"+a+"\n"+"b sayısının değeri:"+b+"\n"+"Toplamın değeri:"+toplam);
/*-----------------------------------------------------------------------------------------------------*/

            int uzunluk, alan, cevre;
            Console.Write("Karenin uzunluğunu girin:");
            uzunluk = Convert.ToInt32(Console.ReadLine());
            alan = uzunluk * uzunluk;
            cevre = 4 * uzunluk;

            Console.WriteLine("Karenin uzunluğu:" + uzunluk + "\n" + "Alan:" + alan + "\n" + "Çevresi:" + cevre);
/*-----------------------------------------------------------------------------------------------------*/

int uzunKenar, kisaKenar;

            Console.Write("Uzun kenarı girin:");
            uzunKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kısa kenarı girin:");
            kisaKenar = Convert.ToInt32(Console.ReadLine());

            int alan = uzunKenar * kisaKenar;
            int cevre = 2 * (uzunKenar + kisaKenar);

            Console.WriteLine("Dikdörtgenin kısa kenarı:" + kisaKenar);
            Console.WriteLine("Uzun kenarı:" + uzunKenar);
            Console.WriteLine("Dikdörtgenin alanı:" + alan + " " + "Dikdörtgenin çevresi:" + cevre);
/*-----------------------------------------------------------------------------------------------------*/

double pi = 3.14;
            double alan, cevre, yaricap;

            Console.Write("Yarıçap değerini girin:");
            yaricap = Convert.ToDouble(Console.ReadLine());
            alan = pi * yaricap * yaricap;
            cevre = 2 * pi * yaricap;

            Console.WriteLine("pi değeri:" + pi + "\n" + "Yarıçap:"+yaricap+"\n"+"Alan:"+alan+"\n"+"Çevre:"+cevre);
/*-----------------------------------------------------------------------------------------------------*/

int vize, final;
            double ortalama;

            Console.Write("Vize notunu girin:");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu girin: ");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = vize * 0.4 + final * 0.6;

            Console.WriteLine("Vize notunuz:" + vize);
            Console.WriteLine("Final notunuz:" + final);
            Console.WriteLine("Ortalamanız:" + ortalama);
/*-----------------------------------------------------------------------------------------------------*/

int a = 22 / 7;
            float b = 22f / 7f;
            double c = 22d / 7d;

            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("c:" + c);