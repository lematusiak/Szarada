// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Lekcja 055 ŁĄCZENIE TEKSTU & FORMATOWANIE "WRITELINE"

// ŁĄCZENIE TEKSTU
/*
string s1 = " Witaj";
string s2 = " Świecie";
string s3 = s1 + s2;

Console.WriteLine(  s3);
Console.WriteLine(  s1 +  s2);    // Można również tak. 

// Poniżej wyświetli się Witaj Świecie. Uwaga, jeśli nie zrobimy pauzy
// w drugim stringu WitajŚwiecie wyświetli się w jednym ciągu.

// Powyższe łączenie teksty to Kontagenacja. 
// Nie jest to dodawanie, tylko doklejanie tekstu do tekstu
// Odnosi się do łączenia ciągów znaków (stringów).
// Jest przydatna, gdy chcemy stworzyć np. komunikat powitalny,
// w którym wyświetlamy imię użytkownika wraz z przywitaniami.

// FORMATOWANIE WRITELINE

// W formatowaniu tekstu chodzi o to, że możemy łączyć dwie zmienne (s1 + s2)
// oraz doklejać (wpisywać) tekst, jak poniżej
// Ważne aby tekst wpisywać w "cudzysłowie"

// Console.WriteLine( s1 +  s3  +  " Marniutki Globie !!! ");

// Możemy w nawiasach klamrowych podać indeks, robimy to po przecinku 
// Indeksy liczone są od zera, bo programiści uznali, 
// że zero jest liczbą dodatnią
// W poniższym indeks {0} wyświetli zmienną s1
// Czyli "Witaj Świecie Marniutki Globie!!! Witaj Świecie

// Console.WriteLine(  s1 + s2 + "Marniutki Globie!!! {0} {1}", s1, s2);

// Więc widzimy do indeksu 0 jest przypisana zmienna s1 "Witaj" 
// a do indeksu s2 "Świecie"

// Mamy jeszcze swojego rodzaju mosyfikator slesz z literą \n
// Tworzy nową linię
// W tym przypadku indeks 1 w postaci zmiennej s2 będzie napisany linię niżej
// Jeśli dodamy 3x \n \n \n jak poniżej zmienna s2 wyświetli sie trzy linie niżej
// NIe musimy tworzyć dodatkowego cw, żeby była dodatkowa linia

// Console.WriteLine(s1 + s2 + "Marniutki Globie!!! {0} \n\n\n {1}", s1, s2);
*/


// MODYFIKACJA WYGLĄDU KONSOLI

// Modyfikacja może dotyczyć kolorów konsoli
// Jeśli po jednym, a przed drugim cw wpiszemy Consol. (consol kropka)
// to jest mnóstwo opcji, żeby skorzystać ze narzędzi visual studio
// Np wpisując consol.col - wyświetli się BackgraundColor (kolor tła)
// Foregraund Color (zmiana koloru) lub ResetColor (wyresetowanie kolorów)


// 

string s1 = " Witaj";
string s2 = " Świecie";
string s3 = s1 + s2;

Console.WriteLine(s3);
Console.WriteLine(s1 + s2);
Console.ForegroundColor = ConsoleColor.Red ;
Console.WriteLine(s1 + s2 + "Marniutki Globie!!! {0} \n\n\n {1}", s1, s2);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(s1 + s2 + "Marniutki Globie!!! {0} \n\n\n {1}", s1, s2);
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine(s1 + s2 + "Marniutki Globie!!! {0} \n\n\n {1}", s1, s2);
Console.ResetColor();
Console.WriteLine(s1 + s2 + "Marniutki Globie!!! {0} \n\n\n {1}", s1, s2);
Console.ReadKey();       // tutaj zatrzymujemy program - od tego jest to polecenie
Console.Clear();         // po kliknięciu obojętnie jakiego klawisza, wszystko z konsoli zniknie       


//Poniżej konsole z akapitów 68,69 wyświetlą się normalnie\
// z akapitu 71 na czerwono
// z akapitu 73 na niebiesko
//
// kolory są tutaj tylko polami dlatego nie są  przechowywane w nawiasach
// (zapis = ConsoleColor.Blue), są to tylko liczby (oznaczające dany kolor)
// Nie są to metod, ponieważ nie robią żadnych obliczeń, tak jak 
// powiedzieliśmy są tylko przypisanymi liczbami np. 12 dla koloru red
// Używając Console BackgroundColor zmieniamy tło tekstu (akapit 75 - green)

// Consol.ResetColour (); to metoda ponieważ ona coś restartuje,
// nie przechowuje informacji pojedyńczej tylko wykonuje jakieś działania
// Widzimy, że jest to metoda, są nawiasy, i tak będziemy to rozróżniać
// Akapit  77 (przedostatni) ustawi nam wszystko do ustawień domyślych,
// czyli ustawi czarne tło, biały tekst

// Akapit 78 (zatrzymujemy program przez Console.ReadKey();
// i chcemy wszystko wyczyścić przez Console.Clear(); akapit 79
// UWAGA: po wciśnięciu obojętnie jakiego klawisza, wszystko z konsoli
// zostanie usunięte - zadziała clear - czyszczenie!!!

// Dość Pan! Dziekuję 30 listopada 2023



Console.ReadKey();


