using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                var input = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan input : ");

                var jumlahPembagi = 0;
                for (int i = 1; i <= input; i++)
                    if (input % i == 0) jumlahPembagi++;

                if (jumlahPembagi == 2)
                    Console.WriteLine("PRIMA\n");
                else
                    Console.WriteLine("BUKAN PRIMA\n");

                Console.WriteLine("Tekan keyboard untuk melanjutkan");
                Console.ReadKey();
            }
        }
    }
}
