// Esit Degildir : !=

//1-Sayısal değerlerde

int s1 = 5;
int s2 = 6;

//if kullanımı
if (s1 != s2)  // s1 eğer s2 ye eşit değilse durum: true
{
    //eğer eşit değilse bu blok çalışsın. Yani buradaki kodlar çalışacak
    Console.WriteLine("s1 s2 ye eşit değildir.");
}
else //false
{
    //diğer durumda zaten s1 s2 ye eşittir
    Console.WriteLine("s1 s2 ye eşittir.");
}

//bool ile kullanımı
bool esitDegilMidir = s1 != s2;
Console.WriteLine(esitDegilMidir); //s1 s2 ye eşit midir? program burayı ya true ya da false döndürür
                                   //Çıktı: True

//2-String ifadelerde

string txt = "Hello";
string txt2 = "World";

//if kullanımı

if(txt != txt2)
{
    Console.WriteLine("txt txt2 ye eşit değildir");
}

//Soru: Kullanıcının girdiği iki tam sayının eşit olup olmadığını kontrol eden c# kodlarını yazınız

//Adım 1: Kullanıcıdan iki sayı girmesini iste
//Adım 2: Bu iki sayının eşit olup olmadığını kontrol et
//Adım 3: Bu iki sayı eşit değilse 1. sayı 2.sayıya eşit değildir yazsın


Console.WriteLine("1.Sayı giriniz: ");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("2.Sayı giriniz: ");
int sayi2 = int.Parse(Console.ReadLine());

if(sayi1 == sayi2)
{
    Console.WriteLine("1.Sayı 2.Sayıya eşittir.");
}
else
{
    Console.WriteLine("1.Sayı 2.Sayıya eşit değildir.");
}

