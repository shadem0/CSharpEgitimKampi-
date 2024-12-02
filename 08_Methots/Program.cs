using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            // Geriye değer döndürmeyen metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşe","Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //string customer = CustomerName();

            //Console.WriteLine(customer);

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return $"{name} {surname}";
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametleri Metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke: {countryName} - Başkent: {capital} - Bayrak Rengi: {flagColor}";
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametleri Metotlar
            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,97));
            //Console.WriteLine(Sum(35,27));
            //Console.WriteLine(Sum(145,677));
            //Console.WriteLine(Sum(25,93));
            //Console.WriteLine(Sum(423,15));
            //Console.WriteLine(Sum(553,865));

            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return $"{student} isimli öğrenci sınavı geçti. Ortalama: {result}";
                }
                else
                {
                    return $"{student} isimli öğrenci sınavı geçemedi. Ortalama: {result}";
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
