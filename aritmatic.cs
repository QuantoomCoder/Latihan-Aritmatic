using System;

namespace Tugas_Lat_Aritmatic
{
    class aritmatic
    {
        static void Main()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("           Perbelanjaan");
            Console.WriteLine("=================================");
            Console.WriteLine(" List Barang : ");
            Console.WriteLine("- Mouse      Rp. 70.000");
            Console.WriteLine("- Keyboard   Rp. 155.000");
            Console.WriteLine("- Monitor    Rp. 423.000");
            Console.WriteLine("=================================");

            Console.Write("Masukkan jumlah Mouse : ");
            int mouse = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan jumlah Keyboard : ");
            int keyboard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan jumlah Monitor : ");
            int monitor = Convert.ToInt32(Console.ReadLine());

            int totalMouse = mouse * 70000;
            int totalKeyboard = keyboard * 155000;
            int totalMonitor = monitor * 423000;

            Console.WriteLine("=================================");
            Console.WriteLine("           Total Harga");
            Console.WriteLine("=================================");
            Console.WriteLine($"Total Harga Mouse      : Rp. {totalMouse}");
            Console.WriteLine($"Total Harga Keyboard   : Rp. {totalKeyboard}");
            Console.WriteLine($"Total Harga Monitor    : Rp. {totalMonitor}");
            Console.WriteLine("=================================");
            Console.WriteLine("         Harga Diskon 10%");
            Console.WriteLine("=================================");
            Console.WriteLine($"Harga Diskon Mouse      : Rp. {totalMouse * 0.9}");
            Console.WriteLine($"Harga Diskon Keyboard   : Rp. {totalKeyboard * 0.9}");
            Console.WriteLine($"Harga Diskon Monitor    : Rp. {totalMonitor * 0.9}");
            Console.WriteLine("=================================");

        }
    }
}