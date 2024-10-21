using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler = 1+2+3+4+5+6 = 3+3 = 6+4 = 10+5 = 15+6 = 21

            //For(x;y;z)
            //x = başlangıç
            //y = bitiş
            //z = artış | azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adet sayısını giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Türkiyem");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //1-20 arasındaki çift sayıların toplamı
            //int evenNumber = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenNumber += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------TOPLAM------");
            //Console.WriteLine(evenNumber);

            //1-50 arasında 7 ile tam bölünen kaç sayı vardır
            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {                    
            //        Console.WriteLine(i);
            //        count++;
            //    }                
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
            //}
            #endregion

            #region While Döngüsü

            //while(Şart)
            //{
            //işlemler
            //artış | azalış
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Loops");
            //    i++;
            //}

            //1-10 arasında 3 e tam bölünen sayılar While ile
            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //1-10 arasındaki sayıların toplamı
            //int i = 1;
            //int totalValue = 0;

            //while (i <= 10)
            //{
            //    totalValue += i;
            //    i++;
            //}
            //Console.WriteLine(totalValue);
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

            Console.Write("Lütfen 3 basamaklı bir sayı giriniz : ");
            int number = int.Parse(Console.ReadLine());

            int sum, ones, tens, hundreds;

            if (number >= 100 && number <= 999)
            {
                ones = number % 10;
                tens = (number % 100) / 10;
                hundreds = number / 100;

                Console.WriteLine(ones + "-" + tens + "-" + hundreds);

                sum = ones + tens + hundreds;

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 3 basamaklı olmalıdır!!!");
            }
            #endregion

            Console.Read();
        }
    }
}
