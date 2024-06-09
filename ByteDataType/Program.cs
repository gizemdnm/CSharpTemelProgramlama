//-------ByteDataType------

//byte 0 ile 255 arasında değer depolayabilmektedir.

byte ilkDeger = 1;
byte ikinciDeger2 = 2;
byte ucuncuDeger3 = 3; //Türkçe karakter kullanmama
Console.WriteLine("İlk değer: " + ilkDeger);
Console.WriteLine("ikinci değer: " + ikinciDeger2);
Console.WriteLine("Üçüncü değer: " + ucuncuDeger3);

//0 ile 255 değer tutma
//byte dorduncuDeger = 256;
byte dorduncuDeger = 250;
Console.WriteLine("Dördüncü değer: " + dorduncuDeger);

//Min Value Kullanımı
byte minValue = byte.MinValue;
byte maxValue = byte.MaxValue;
Console.WriteLine("byte tipi min değeri: " + minValue);
Console.WriteLine("byte tipi max değeri: " + maxValue);

//MaxValue ve MinValue değerlerini tek satırda yazdıralım

Console.WriteLine("Byte tipi min değeri " + minValue +  "\nbyte tipi max değeri " + maxValue);

//Değer atamadan Max ve Min değeri hesaplayan console app
Console.WriteLine("byte tipi min değeri: " + byte.MinValue + " byte tipi max değeri: " + byte.MaxValue);






