// Esittir Op: =

//1-Temel kullanım (aynı değerler)

using System.Reflection.Metadata;

int x = 5;
int y = 5;


//x ve y birbirine eşit midir kontrol et
bool sonuc = (x == y);
Console.WriteLine(sonuc);
//Console.ReadKey();


//2-Farklı değerler

int x2 = 20;
int y2 = 40;

//x ve y birbirine eşit midir kontrol et
bool sonuc2 = (x2 == y2); //false
Console.WriteLine(sonuc2);
//Console.ReadKey();


//3-Aynı String ifadelerin Karşılaştırma

string text = "Hello";
string text2 = "Hello";
bool textSonuc = (text == text2); //true

Console.WriteLine(textSonuc);


//4-Farklı veri tiplerinin karşılaştırılması


//Örnek 1
int s = 5;
string degisken = "12344";
bool sonuc3 = (s == int.Parse(degisken));
Console.WriteLine("Sonuç 3: " + sonuc3);

//Örnek 2
int s1 = 5;
string degisken1 = "5";
bool sonuc4 = (s1 == Convert.ToInt32(degisken1)); /*burada sonuç true "degisken" adındaki değişkeni int tipine dönüştürdükten
                                                    sonra değerler eşit olduğu durum true döndü*/
Console.WriteLine("Sonuç 4: " + sonuc4);

