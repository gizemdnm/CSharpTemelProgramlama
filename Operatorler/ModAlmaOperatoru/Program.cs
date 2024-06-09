/*
 
----Mod Alma Operatoru----

    Mod alma operatoru (%) => yüzde ifadesi ile gösterilir.
    Mod alma iki sayının bölümünden kalanı verir.
 
 */

//Soru 1: Kullanıcıdan iki sayı isteyin. Birinci sayının ikinci sayıya bölümünden kalanı veren C# console uygulamasını yazın

using System.ComponentModel.Design;

/*Console.Write("1.Sayı Girin: ");
int s1 = int.Parse(Console.ReadLine());
Console.Write("2.Sayı Girin: ");
int s2 = int.Parse(Console.ReadLine());

int kalan =  s1 % s2;
Console.WriteLine(kalan);*/

//Soru 2: Mod alma ve Çift sayı kontrolü

Console.WriteLine("Bir sayı girin: ");
int sayi = int.Parse(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine(sayi + " çift sayıdır.");
}
else
{
    Console.WriteLine(sayi + " tek sayıdır.");
}


