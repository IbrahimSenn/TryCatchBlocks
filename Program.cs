using System;
using System.ComponentModel;

namespace TryCatch
{
public class Program
{
   
    

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı giriniz..");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı :" + sayi );

        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata : **" + ex.Message.ToString());
        }

        finally // Opsinional block..
        {
            Console.WriteLine("İşlem tamamlandı*********");
        }

        Console.WriteLine("***Bu kod bloğu başarılı bir şekilde çalışmalı***");


        try
        {
            int a = int.Parse(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer giridinz.."); // TODO
            Console.WriteLine(ex);
        }

    }
    }
}
