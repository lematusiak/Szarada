// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Lekcja 054 Internet 05 KONWERSJA TYPÓW STRING > INT, INT > STRING

// Konwersja typów oznacza zmianę wartości z jednego typu danych na inny.
// Na przykład, jeśli chcesz zmienić tekst na liczbę lub odwrotnie,
// musisz skorzystać z konwersji typów.
// Można to porównać do sytuacji w życiu codziennym,
// kiedy musisz przekształcić coś w coś innego.
// Na przykład, kiedy przeliczasz kilogramy na funty lub mile na kilometry.
// Ważne jest, aby pamiętać, że niektóre konwersje mogą powodować utratę danych,
// na przykład gdy przekształcasz liczbę zmiennoprzecinkową na liczbę całkowitą.
// 
// STRING jest typem TEKSTOWYM, int jest typem LICZBOWYM


// gdybyśmy chcieli przekonwertować niejawnie int na string int i  = s + 2, 
// to nie ma takiej możliwości. trzeba użyć innego sposobu

// a więc musimy przekonwertować typ tekstowy na typ liczbowy

class Program
{
static void Main(string[]args)
    {

        // KONWERSJA STRING NA INT

        string s = Console.ReadLine(); // string s jest tylko tekstem
                                       // nie jest wartością logiczną
        
        int i = int.Parse(s) + 2; // przez Parse wyciągamy wartość liczbową
                                  // jaka siedzi w typie string s
                                  // od teraz jeśli coś będziemy na konsoli liczyli
                                  // będzie dodawało, przestanie być tekstem

        Console.WriteLine( i); // Jeśli wpiszemy 5, wyświetli się 7

       // 7 dlatego, że  - int.Parse(s) - będzie konkretnie tą naszą wpisaną 5
       // 5 do której dodamy 2 i wyjdzie to co równa się int i. (int i)
       // A WIĘC STRING S stał się WARTOŚCIĄ LOGICZNĄ w postaci INT.PARSE (S)
       // W taki sposób zamieniamy wartość tekstową na logiczną
       // Jeśli za int.Parse(s) wpiszemy 9, wyświetli się 11 itd, itd


// KONWERSJA W DRUGĄ STRONĘ (Z INT NA STRING)

//  s = i; (jeśli tak chcielibyśmy przekonwertować wyświetli się błąd,
// nie można niejawnie tak przekonwertować int na string
// czyli pamiętamy wlać butlę z wodą z inta do butli stringa

/* ZMIENNA i JEST JUŻ OBIEKTEM i przechowuje w sobie dziedziczone różne metody
 * do których po kropce możemy uzyskać dostęp
 * 
 * Dlatego nie da się jej przekonwertować, ale możemy coś zaradzić,
 * czyli po kropce możemy uzyskać dostęp do jednej z metod.
 * Jedną z metod jest właśnie ToString. - a tu string oznacza 
 * zamień na typ tekstowy. (Czyli będzie s = i.ToString();) 24.40
 * 
 * Zmienna staje się obiektem, gdy przypisujemy do niej instancję 
 * (konkretny egzemplarz) klasy.  
 * Innymi słowy, kiedy używamy konstruktora klasy, tworząc nowy obiekt, 
 * i przypisujemy go do zmiennej. 
 * Na przykład, jeśli mamy klasę o nazwie "Samochod" 
 * i tworzymy nowy obiekt tej klasy, np. samochod1, używając konstruktora,
 * to możemy przypisać ten obiekt do zmiennej samochod1. 
 * Od tego momentu, zmienna samochod1 jest obiektem typu "Samochod" 
 * i możemy używać go do wywoływania metod 
 * i dostępu do właściwości zdefiniowanych w klasie "Samochod".
 * Podobnie jak w życiu codziennym, kiedy otrzymujemy np. klucz do mieszkania, 
 * staje się on przedmiotem, który możemy używać do otwierania drzwi.
 * 
 * 
 * 
 * 
 * 
 */

// SPOSÓB NA KOWNWERSJĘ INT NA STRING


s = i.ToString();   // ToString oznacza: zamień na typ tekstowy
Console.WriteLine(s);

Console.ReadKey();




}






}