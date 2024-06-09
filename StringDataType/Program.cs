/* 
 ---------String Data Type----------
    -String veri tipi, metin veya karakter dizelerini depolamak için kullanılır.
    -Bir kez oluşturulduktan sonra, bir string değerinin içeriği değiştirilmez.
     yani bir kez atandığında üzerinde değişiklik yapılmaz.
    -Metin işleme işlemlerinde, string veri tipi çok yaygın olarak kullanılır.
    -Metin içinde değişkenler veya diğer metin ögeleri ile birleştirme yaparken, 
     string.Format veya $**(string interpolation) gibi özellikler kullanılabilir.
 */

//1-Birkaç değişken tanımlayarak string ifadeleri birleştirme

/*string name = "Metehan";
string surname = "Gencer";
int age = 18;
Console.WriteLine("Adı: " + name + "\nSoyadı: " + surname + "\nYaşı: " + age);*/

//benim adım Alperen Bizel ve ben 18 yaşındayım
/*string sentence = "benim adım Alperen Bizel ve ben 18 yaşındayım";
Console.WriteLine(sentence)*/

/*string fullName = "Gizem Dönüm";
int age1 = 30;
string message = "Benim adım " + fullName + " ve ben " + age1 + " yaşındayım";
Console.WriteLine(message);*/

//2-String Interpolation ile Birleştirme
//benim adım Alperen Bizel ve ben 18 yaşındayım

/*string fullName2 = "Alperen Bizel";
string message2 = $"Benim adım {fullName2} ve ben {age1} yaşındayım.";
Console.WriteLine(message2);
*/

/* 
 -Değişken ekleme: $ sembolü kullanarak bir dize içine ({} içinde belirtilen ifadeleri) yerleştirebiliriz.
 Bu daha önce string.Format veya string.Concat gibi yöntemlerle yapılıyordu ancak $ sembolü bu işlemi daha kolay
 ve okunabilir hale getirir.

 -İfade ekleme: {} içinde herhangi bir C# ifadesini (metot çağrısı, matematiksel işlem, koşul ifadeler vb.) kullanabiliriz.

 -Okunabilirlik ve kısa yazım: String Interpolation, dize içinde değişken veya ifadeleri doğrudan yazmamıza izin verir.
  Bu da kodun daha okunabilir ve kısa olmasına olanak sağlar.

 */

//string.Concat Kullanımı

/*string firstName = "Osman";
string lastName = "Özdenören";
string fullName = string.Concat(firstName, " ", lastName);
Console.WriteLine(fullName); // Çıktı: Osman Özdenören
*/

//string.Format Kullanımı

//Benim Adım Osman Özdenören ve Ben 28 Yaşındayım

/*string fullName1 = "Osman Özdenören";
int age = 28;
string message4 = string.Format("Benim Adım {0} ve ben {1} yaşındayım", fullName1, age);
Console.WriteLine(message4);
*/
//{0}=>ilk değer, {1}=>ikinci değer. Yer tutucuları 
//Bu örnekte, string.Format yöntemiyle {0} ve {1} yer tutucuları ile dize biçimlendirme yapılmıştır.

//string.Format içinde sırasıyla fullName1 ve age değişkenleri yer tutucuları yerine geçer.

//1.Soru Aşağıdaki çıktının kodlarını yazın
/*Çıktı: 1.Sayı: 15
         2.Sayı: 20
         15 ve 20 sayılarının toplamı: 35
    
    */

/*int number = 15;
int number2 = 20;
int toplam = number + number2;
Console.WriteLine("1.Sayı: " + number + "\n2.Sayı: " + number2 + "\n15 ve 20 sayılarının toplamı: " + toplam);*/

/*Console.Write( "1.Sayıyı Girin: ");
int s1 = int.Parse(Console.ReadLine());

Console.Write("2.Sayıyı Girin: ");
int s2 = int.Parse(Console.ReadLine());
int toplam1 = s1 + s2;
Console.WriteLine(s1 + " ve " + s2 + "sayılarının toplamı: " + toplam1);

Console.ReadLine();*/

//2.Soru aşağıdaki algoritmayı koda dönüştürün
/*
 1.Başla
 2.Kullanıcının ismini isteyin
 3.Kullanıcının yaşını isteyin
 4.Ekranda Merhaba Ben 27 yaşındayım yazsın
 5.Bitir
*/


Console.Write("Kullanıcının Adı: ");
string adi = Console.ReadLine();

Console.Write("Kullanıcının Yaşı: ");
int yas = int.Parse(Console.ReadLine());

string message6 = "Merhaba! Ben " + adi + " ve ben " + yas + " yaşındayım.";
Console.WriteLine(message6);
Console.ReadLine();


//Build işlemi kısayolu=> ctrl + b



