using System;

class KodeProduk
{
    public enum ProdukElektronik
    {
        Laptop, Smartphone, Tablet, Headset, Keyboard,
        Mouse, Printer, Monitor, Smartwatch, Kamera
    };

    public static string GetKodeProduk(ProdukElektronik produk)
    {
        string[] kodeProduk = {"E100", "E101", "E102", "E103", "E104",
        "E105", "E106", "E107", "E108", "E109"};

        return kodeProduk[(int)produk];
    }
    
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Daftar Produk Elektronik dan Kode Produk: ");

        foreach(KodeProduk.ProdukElektronik produk in Enum.GetValues(typeof(KodeProduk.ProdukElektronik)))
        {
            string kodeProduk = KodeProduk.GetKodeProduk(produk);
            Console.WriteLine($"{produk} : {kodeProduk}");
        }
    }
}
