using System;
using System.Collections.Generic;

//class KodeProduk
//{
//    public enum ProdukElektronik
//    {
//        Laptop, Smartphone, Tablet, Headset, Keyboard,
//        Mouse, Printer, Monitor, Smartwatch, Kamera
//    };

//    public static string GetKodeProduk(ProdukElektronik produk)
//    {
//        string[] kodeProduk = {"E100", "E101", "E102", "E103", "E104",
//        "E105", "E106", "E107", "E108", "E109"};

//        return kodeProduk[(int)produk];
//    }
    
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Daftar Produk Elektronik dan Kode Produk: ");

//        foreach(KodeProduk.ProdukElektronik produk in Enum.GetValues(typeof(KodeProduk.ProdukElektronik)))
//        {
//            string kodeProduk = KodeProduk.GetKodeProduk(produk);
//            Console.WriteLine($"{produk} : {kodeProduk}");
//        }
//    }
//}

public class FanLaptop
{
    public enum State {Quite, Balanced, Performance, Turbo};

    private State stateSekarang;

    public FanLaptop()
    {
        stateSekarang = State.Quite;
        Console.WriteLine("Quite Mode");
    }

    public void Perintah(string command)
    {
        switch (stateSekarang)
        {
            case State.Quite:
                if (command == "Balanced")
                {
                    stateSekarang = State.Balanced;
                    Console.WriteLine("Fan Quite berubah menjadi Balanced");
                } else if (command == "Turbo")
                {
                    stateSekarang = State.Turbo;
                    Console.WriteLine("Fan Quite berubah menjadi Turbo");
                }
                break;

            case State.Balanced:
                if (command == "Quite")
                {
                    stateSekarang = State.Quite;
                    Console.WriteLine("Fan Balance berubah menjadi Quite");
                } else if (command == "Performance")
                {
                    stateSekarang = State.Performance;
                    Console.WriteLine("Fan Balance berubah menjadi Performance");
                }
                break;

            case State.Turbo:
                if (command == "Quite")
                {
                    stateSekarang = State.Quite;
                    Console.WriteLine("Fan Turbo berubah menjadi Quite");
                } else if (command == "Performance")
                {
                    stateSekarang = State.Performance;
                    Console.WriteLine("Fan Turbo berubah menjadi Performance");
                }
                break;

            case State.Performance:
                if (command == "Balanced")
                {
                    stateSekarang = State.Balanced;
                    Console.WriteLine("Fan Balanced berubah menjadi Balanced");
                } else if (command == "Turbo")
                {
                    stateSekarang = State.Turbo;
                    Console.WriteLine("Fan Balanced berubah menjadi Turbo");
                }
                break;
        }
    }
}

public class Program
{
    static void Main()
    {
        FanLaptop kipas = new FanLaptop();

        Console.WriteLine("\nQuite -> Balanced");
        kipas.Perintah("Balanced");

        Console.WriteLine("\nBalanced -> Performance");
        kipas.Perintah("Performance");

        Console.WriteLine("\nPerformance -> Turbo");
        kipas.Perintah("Turbo");

        Console.WriteLine("\nTurbo -> Quite");
        kipas.Perintah("Quite");

        Console.WriteLine("\nQuite -> Turbo");
        kipas.Perintah("Turbo");

        Console.WriteLine("\nTurbo -> Performance");
        kipas.Perintah("Performance");

        Console.WriteLine("\nPerformance -> Balanced");
        kipas.Perintah("Balanced");

        Console.WriteLine("\nBalanced -> Quite");
        kipas.Perintah("Quite");
    }
}