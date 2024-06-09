/*---------CharDataType---------

 --Tek bir karakter tutar.
 --Tek tırnak içerisinde olur.
 --C# programlama dilinde tek bir unicode karakterini temsil eder.
 --16 bitlik bellekte yer kaplar

    ------alt + shift => toptan hizalama yapar

*/

using System.Text;

Console.OutputEncoding = Encoding.UTF8;

char letter = 'a'; // karakter tutar. Unicode değeri 97
char letter2 = 'h'; // unicode değeri 104
char digit = '2';
char symbol = '$'; //unicode değeri 36
char unicodeChar = '\u03A9';
 
Console.WriteLine(letter); // karakter gösterimi
Console.WriteLine(letter + letter2); // unicode değeri olan iki değişkeni toplar

Console.WriteLine(digit);
Console.WriteLine(symbol);
Console.WriteLine(unicodeChar);

