using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities =
            //{
            //    "milano",
            //    "roma",
            //    "budapeşte",
            //    "ankara",
            //    "istanbul",
            //    "varşova"
            //};

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 45, 77, 65, 43, 765, 54, 43, 654, 345, 325, 54, 79, 98, 21234, 5443, 2543 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 77, 65, 43, 765, 54, 41, 654, 345, 325, 58, 79, 98, 21234, 5443, 2543 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 77, 65, 43, 765, 54, 43, 654, 345, 325, 54, 79, 98, 21234, 5443, 2543 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var?");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResults = 0;

                // Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. Sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResults += value; // Notları topluyoruz
                }

                studentExamAvg[i] = totalExamResults / 3;

            }
            Console.WriteLine();
            // Sınav ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");

                }
                Console.WriteLine("---------------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
