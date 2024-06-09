/*

----Carpma Ve Bölme Operatoru------

Çarpma Operatörü: *
Bölme Operatörü: /

 */

//1-Çarpma Operatörü: *

using System.Transactions;

int a = 15;
int b = 3;
int carpim = a * b; //Çıktı: 45
Console.WriteLine("Çarpım: " + carpim);

//2-Bölme Operatörü: /

int bolum = a / b;
Console.WriteLine("Bölüm: " + bolum); // Çıktı:5

//Not: Bölme işlemi tam sayı türlerinde (int,long) yapıldığında sonuç tam sayı olur ve kesirli kısım atılır.

int x = 7;
int y = 3;
int sonuc = x / y;
Console.WriteLine(sonuc); //Çıktı: 2

//Not: Kesirli sonucu görmek istersek en az bir değişkeni double türünde yapmamız gerekiyor

double x2 = 7;
double y2 = 2;
double sonuc2 = x2 / y2;
Console.WriteLine(sonuc2); //Çıktı: 3,5

//Soru 1: Ekrana "Çarpım: 200" yazdıralım

//Soru 2: Ekrana "Bölüm:2" yazdıralım

//Soru 3: Ekrana "Kesirli Bölüm: 14.5" yazdıralım

int e = 20;
int t = 10;
int carp = e * t;
Console.WriteLine("Çarpım: " + carp);

int bol = e / t;
Console.WriteLine("Bölüm: " + bol);

double w = 43.5;
double h = 3;
double bol2 = w / h;
Console.WriteLine("Kesirli Bölüm: " + bol2);

//Kullanıcıdan değer alma

Console.WriteLine("1.Sayı giriniz: ");
int s1 = int.Parse(Console.ReadLine());

Console.WriteLine("2.Sayı giriniz: ");
int s2 = int.Parse(Console.ReadLine());

//if kullanmadan bölme işlemi

double bolum2 = (double)s1 / s2;
Console.WriteLine("Bölüm: " + bolum2);

Console.ReadLine();



