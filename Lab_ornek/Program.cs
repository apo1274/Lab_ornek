using System;

namespace Lab_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir;
            int sutun;
            double esik;
            int esit = 0;
            double sum = 0;

            Console.WriteLine("Oluşturmak istediğiniz satır sayısını giriniz : ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oluşturmak istediğiniz sütun sayısını giriniz : ");
            sutun = Convert.ToInt32(Console.ReadLine());


            double[,] dizi = new double[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                Console.WriteLine("Şimdi {0}. satırdaki değerleri girinz", i + 1);
                for (int j = 0; j < sutun; j++)
                {
                    Console.WriteLine("{0}. satır {1}. sütundaki değeri giriniz :", i + 1, j + 1);
                    dizi[i, j] = Convert.ToDouble(Console.ReadLine());


                }

            }
            for (int i = 0; i < satir; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(dizi[i, j] + "|");

                }
            }
            Console.WriteLine("  ");
            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine(" ");


            //EŞİK DEĞERDEN KÜÇÜK, BÜYÜK YA DA EŞİT SAYILARI BULAN PROGRAM!!

            Console.WriteLine("Bir Eşik değer giriniz :");
            Console.WriteLine(" ");
            esik = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (dizi[i, j] > esik)
                    {
                        Console.WriteLine("Eşikten büyük sayı : " + dizi[i, j]);
                    }
                    else if (dizi[i, j] < esik)
                    {
                        Console.WriteLine("Eşikten kücük sayı : " + dizi[i, j]);
                    }
                    else
                    {
                        esit++;
                    }
                }

            }
            Console.WriteLine("Eşik değere eşit sayı adedi : " + esit);


            Console.WriteLine("************************************");
            //İKİ BOYUTLU DİZİDEKİ SAYILARIN TOPLAMINI BULAN PROGRAM!!

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    sum += dizi[i, j];
                }
            }
            Console.WriteLine("Sayıların toplamı : " + sum);

            Console.ReadKey();
        }
    }
}
