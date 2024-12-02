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
            #region Main Subjects
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Başlangıçlar");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6 - İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");



            // String
            //Degisken_Turu degisken_Adi;

            //string name;
            //name = "Emir";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+905004003020";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();    
            //Console.WriteLine("--------------------------------------------------");    
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+904003008070";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("--------------------------------------------------");



            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "  TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalPrice = (hamburgerCount * hamburgerPrice) + (cokeCount * cokePrice) + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("**** Müşterinin Aldıkları ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerCount + " Tane" + " | " + "Tutar: " + hamburgerCount * hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaCount + " Tane" + " | " + "Tutar: " + pizzaCount * pizzaPrice + " TL");
            Console.WriteLine("----Kızartma: " + friesCount + " Tane" + " | " + "Tutar: " + friesCount * friesPrice + " TL");
            Console.WriteLine("----Su: " + waterCount + " Tane" + " | " + "Tutar: " + waterCount * waterPrice + " TL");
            Console.WriteLine("----Kola: " + cokeCount + " Tane" + " | " + "Tutar: " + cokeCount * cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadeCount + " Tane" + " | " + "Tutar: " + lemonadeCount * lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("----Toplam Ödenecek Tutar: " + totalPrice + " TL");


            Console.Read();
            #endregion
        }
    }
}
