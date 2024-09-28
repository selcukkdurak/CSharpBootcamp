using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları (Print Commands)

            //Console.WriteLine("Hello World");
            //Console.Write("Selam");
            //Console.WriteLine("C#");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler (Variables)

            //Değişken_türü değişken_adı;

            //string

            //string name;
            //name = "Selçuk";
            //Console.WriteLine(name);

            //camelCase = ilk kelimenin ilk harfinin küçük, sonraki kelimelerin ilk harfinin büyük başlamasıdır.

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Selçuk";
            //customerSurname = "DURAK";
            //customerPhone = "+90 500 400 3020";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "KAYA";
            //customerPhone = "+90 400 300 8070";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int friesPrice = 50;
            int cokePrice = 35;
            int lemonadePrice = 30;
            int waterPrice = 10;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("---- Kızartma: " + friesPrice + "TL");
            Console.WriteLine("---- Kola: " + cokePrice + "TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("---- Su: " + waterPrice + "TL");
            Console.WriteLine();

            int hamburgerCount = 3;
            int pizzaCount = 0;
            int friesCount = 1;
            int cokeCount = 2;
            int lemonadeCount = 1;
            int waterCount = 3;

            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;
            int totalFriesPrice = friesCount * friesPrice;
            int totalCokePrice = cokeCount * cokePrice;
            int totalLemonadePrice = lemonadeCount * lemonadePrice;
            int totalWaterPrice = waterCount * waterPrice;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalFriesPrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion

            Console.Read();
        }
    }
}
