using System;
namespace dotnetprogramlama
{
    class Program
    {
    public static void Main(string[] args)
    {
     
 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("İsminizi giriniz");
string name =Console.ReadLine();
Console.WriteLine("Soyadınızı giriniz");      
string surname =Console.ReadLine();

Console.WriteLine("Merhabalar > "+name+" "+surname);
    }
    }
}