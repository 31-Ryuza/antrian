using System;
using System.Collections;

namespace Antrian
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Antrian_Customer = new Queue();
            Console.WriteLine("Daftar Antrian Customer Gudeg :");
            Antrian_Customer.Enqueue("Antrian 1");
            Antrian_Customer.Enqueue("Antrian 2");
            Antrian_Customer.Enqueue("Antrian 3");
            Antrian_Customer.Enqueue("Antrian 4");
            Antrian_Customer.Enqueue("Antrian 5");
            foreach (var antrian in Antrian_Customer)
            {
                Console.WriteLine(antrian);
            }
            Console.WriteLine($"Jumlah antrian saat ini = {Antrian_Customer.Count}");
            Console.WriteLine($"Antrian yang dipanggil ! {Antrian_Customer.Dequeue()}");
            Console.WriteLine($"Jumlah antrian saat ini = {Antrian_Customer.Count}");
            Console.WriteLine($"Antrian Selanjutnya  = {Antrian_Customer.Peek()} ");
        }
    }
}
