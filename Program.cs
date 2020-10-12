using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlayingEscapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //dy: diz yüksekliği
            //uokc: üst kol çevresi
            int flayingescapes;
            Random erkekdy = new Random();
            Random kadindy = new Random();
            Random erkekuokc = new Random();
            Random kadınuokc = new Random();
            //yazılara renk vermek
            Console.ForegroundColor = ConsoleColor.Green;
            //erkek kol cevresi yuksekligi
            int erkekkolyuksekligi;
            erkekkolyuksekligi = erkekuokc.Next(26, 37);
            Console.WriteLine("ERKEK KOL YÜKSEKLİĞİ: " + erkekkolyuksekligi);
            //kadın kol cevresi yuksekliği
            int kadinkolyuksekligi;
            kadinkolyuksekligi = kadınuokc.Next(23, 38);
            Console.WriteLine("KADIN KOL YÜKSEKLİĞİ: "+kadinkolyuksekligi);
            //kadın diz yuksekliği
            int kadındizyuksekligi;
            kadındizyuksekligi = kadindy.Next(43, 56);
            Console.WriteLine("KADIN DİZ YÜKSEKLİĞİ: "+kadındizyuksekligi);
            //erkek diz yuksekligi
            int erkekdizyuksekligi;
            erkekdizyuksekligi = erkekdy.Next(49, 59);
            Console.WriteLine("ERKEK DİZ YÜKSEKLİĞİ: "+erkekdizyuksekligi);
            Console.WriteLine(" ");
            //renk seçimi
            Console.ForegroundColor = ConsoleColor.White;
            //cinsiyet
            Console.WriteLine("1- ERKEK");
            Console.WriteLine("2- KIZ");
            Console.WriteLine(" ");
            Console.Write("Cinsiyet Gir: ");
            flayingescapes = Convert.ToInt32(Console.ReadLine());
            //yas aralığı
            int yasaraligiaciklama;
            Random yasaraligi = new Random();
            yasaraligiaciklama=yasaraligi.Next(6, 80);
            Console.WriteLine(" ");
            //renk seçimi
            Console.ForegroundColor = ConsoleColor.Gray;
            //kadın erkek seçimi
            switch (flayingescapes)
            {
                //erkek
                case 1:
                    if (yasaraligiaciklama>=6 && yasaraligiaciklama<=18)
                    {
                        //formul
                        double erkeksonuc1;
                        erkeksonuc1 = (erkekdizyuksekligi * 0.68) + (erkekkolyuksekligi * 2.64) - 50.08;
                        Console.WriteLine("ERKEK SONUC: "+erkeksonuc1);
                    }
                    else if (yasaraligiaciklama>=19 && yasaraligiaciklama<=59)
                    {
                        //formul
                        double erkeksonuc2;
                        erkeksonuc2 = (erkekdizyuksekligi * 1.19) + (erkekkolyuksekligi * 3.21) - 86.82;
                        Console.WriteLine("ERKEK SONUC: " + erkeksonuc2);
                    }
                    else if (yasaraligiaciklama>=60 && yasaraligiaciklama<=80)
                    {
                        //formul
                        double erkeksonuc3;
                        erkeksonuc3 = (erkekdizyuksekligi * 1.10) + (erkekkolyuksekligi * 3.07) - 75.81;
                        Console.WriteLine("ERKEK SONUC: " + erkeksonuc3);
                    }
                    break;
                    //kadın
                case 2:
                    if (yasaraligiaciklama>=6 && yasaraligiaciklama<=18)
                    {
                        //formul
                        double kadinsonuc1;
                        kadinsonuc1 = (kadındizyuksekligi * 0.77) + (kadinkolyuksekligi * 2.47) - 50.16;
                        Console.WriteLine("KADIN KİLO: " + kadinsonuc1);
                    }
                    else if (yasaraligiaciklama>=19 && yasaraligiaciklama<=59)
                    {
                        //formul
                        double kadinsonuc2;
                        kadinsonuc2= (kadındizyuksekligi * 1.01) + (kadinkolyuksekligi * 2.81) - 66.04;
                        Console.WriteLine("KADIN KİLO: " + kadinsonuc2);
                    }
                    else if (yasaraligiaciklama>=60 && yasaraligiaciklama<=80)
                    {
                        //formul
                        double kadinsonuc3;
                        kadinsonuc3 = (kadındizyuksekligi * 1.09) + (kadinkolyuksekligi * 2.68) - 65.51;
                        Console.WriteLine("KADIN KİLO: " + kadinsonuc3);
                    }
                    break;
                default:
                    Console.WriteLine("İSTENEN DEĞER ATANAMADI!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
