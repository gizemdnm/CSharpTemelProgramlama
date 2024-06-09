/*
---Toplama ve Çıkarma Operatörleri----

Toplama Operatörü: +
Çıkarma Operatörü: -

 */

//1-Toplama Operatörü => Hem string ifadelerde hem de sayısal verilerde kullanılır.

//a-Sayısal verilerde Kullanımı

using System.Reflection.Metadata;

int a = 5;
int b = 3;
int toplam = a+ b; //Toplam = 8
Console.WriteLine("a ve b nin toplamı: " + (a+b)); //Çıktı: 8

//b-String ifadelerde Kullanımı

string adi = "Eray";
string soyadi = "Sönmezer";
string fullName = adi + " " +soyadi;
Console.WriteLine(fullName);

//2-Çıkarma Operatörü: (-)

int fark = a - b;
Console.WriteLine(fark); //Çıktı: 2

//Çıkarma operatörü string değerler için kullanılmaz. Sadece sayısal değerler üzerinde işlemler yapar.

//Toplama ve Çıkarmada işlem önceliği

int c = 2;
int sonuc = (a + b - c);
Console.WriteLine(sonuc); //Çıktı: 6

/*
 ALGORİTMA
1.BAŞLA
2.Birinci sayıyı gir
3.İkinci sayıyı gir
4.Birinci ve ikinci sayıyı topla
5.Birinci sayıdan ikinci sayıyı çıkar
6.Bitir
 
 */

Console.Write("Birinci sayıyı gir: ");
int s1 = int.Parse(Console.ReadLine());

Console.Write("ikinci sayıyı gir: ");
int s2 = int.Parse(Console.ReadLine());

int toplam1 = s1 + s2;
Console.WriteLine(toplam1);

int fark1 = s1- s2;
Console.WriteLine(fark1);






