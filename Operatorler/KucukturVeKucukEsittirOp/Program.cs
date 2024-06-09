// KüçüktürVeKüçükEşittir : 

//1-Küçüktür Op: <

/*int a = 5;
int b = 6;

if ( a < b )  //true
{
    Console.WriteLine("a b'den küçüktür.");
}
else
{
    Console.WriteLine("a b'den büyüktür.");
}
*/
//Kullanıcıdan yaş bilgisini alıp onun reşit olup olmadığını yazan c# kodlarını yazalım

/*Console.WriteLine("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas < 18)
{
    Console.WriteLine("Henüz Reşit değilsiniz.");
}
else
{
    Console.WriteLine("Reşitsiniz.");
}
*/

//2-Küçüktür Op: <

//Soru: Bir öğrencinin geçme notunu hesaplayan console kodlarını yazın
//Geçme notu: 50
//Eğer not 50'den küçükse kaldı yazın
//Büyükse geçti yazın

/*Console.WriteLine("Aldığınız Not: ");
int not = Convert.ToInt32(Console.ReadLine());

if (not <= 50)
{
    Console.WriteLine("Kaldı");
}
else
{
    Console.WriteLine("Geçti");
}*/

//3-Küçük Eşittir Op: <=

int not1 = 80;
int gecmeNotu = 50;

if (not1 <= gecmeNotu) // false
{

    Console.WriteLine("Notunuz geçme notuna eşit veya daha düşüktür.");
}
else
{
    Console.WriteLine("Notunuz geçme notundan yüksektir.");
}

//Soru: Alınan bir ürüne indirim sağlama

double urunFiyati = 49.99;
double indirimFiyati = 50;

if(urunFiyati <= indirimFiyati)
{
    Console.WriteLine("İndirim hakkınız bulunmuyor");
}
else
{
    Console.WriteLine("İndirim kazandınız");
}



