/*
           ------Int Data Type---------
            --int tipi 4 byte'lık bellekte yer kaplar
            --Tam sayıları tutar
            --En çok kullanılan veri tipidir
            --Büyük sayılarda int tipi çok tercih edilmez. ör TC Kimlik no 11 haneli olduğu için değeri tutamaz
            --Büyük sayılar için genellikle long veri tipi tercih edilir

*/

//1-MaxValue

int maxValue = int.MaxValue;
Console.WriteLine("İnt veri tipinin max değeri: " + maxValue);
//2-MinValue
int minValue = int.MinValue;
Console.WriteLine("İnt veri tipinin min değeri: " + minValue);

//3-Ondalıklı bir sayıyı tam sayı veri tipine dönüştürme

double ondalikliSayi = 7.1;
int tamSayi = (int)ondalikliSayi;
Console.WriteLine("Ondalıklı bir sayıyının tam sayı değerine dönüşümü: " + tamSayi);

//4-ToString ile veri dönüşümü

int sayi = 5;
double ondalikliSayi2 = sayi; // Explicit cast işlemi
//F2 format, sayıyı iki ondalık basamak ile gösterecektir
Console.WriteLine("Ondalıklı sayı: " + ondalikliSayi2.ToString("F2"));
//Çıktı : 5,00

//5-İki sayının toplamını veren console app

int s1 = 15;
int s2 = 5;
int toplam = s1 + s2;
Console.WriteLine("s1 ve s2 nin toplamı: " + toplam);

//6-İki sayının ortalamasını veren console app

int ortalama = toplam / 2;
Console.WriteLine(ortalama);

