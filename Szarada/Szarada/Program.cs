Kurs Adama Lekcja 5 TABLICE, P�TLA FOR Z TABLICAMI

int[] grades = new int[365];
string[] dayOfWeek = new string[7];

// PIERWSZY WZ�R

dayOfWeek[0] = "pn";
dayOfWeek[1] = "wt";
dayOfWeek[2] = "sr";
dayOfWeek[3] = "cz";
dayOfWeek[4] = "pt";
dayOfWeek[5] = "sb";
dayOfWeek[6] = "nd";

Console.WriteLine(dayOfWeek[2]); // zwr�ci sr

// DRUGI WZ�R

string[] week = 
         { " pn", "wt", "sr", " cz", "pt", "sb", "nd" };

Console.WriteLine(); // oddziela linie - pomijane dalej

Console.WriteLine(week[6]); // zwr�ci nd


for (int i = 0; i < 7; i++)
{
    Console.WriteLine("[i]"); // zwr�ci 7x[i]
}


for (int j = 0; j < 7; j++)
{
    Console.WriteLine(j); // zwr�ci 0 1 2 3 4 5 6
}

// ZABAWA Z P�TL�

// Poni�sza p�tla wy�wietli pn wt sr cz pt sb nd. Ale zasada jest taka, �e wiemy, �e g < 7

for (int g = 0; g < 7; g++)
{
    Console.WriteLine(dayOfWeek[g]); 
}

// Ale nie zawsze musimy wiedzie�, od ilu g musi by� mniejsze(drugi slot, druga przestrze�). Gdyby kto� kiedy� w kodzie wyj�ciowym co� zmieni�, �e np k < 1000, to Lenght rozwi�zuje ten problem

for (int k = 0; k < dayOfWeek.Length; k = k + 1)
{
    Console.WriteLine(dayOfWeek[k]); 
                         // zwr�ci pn wt sr cz pt sb nd
}


for (int m = 0; m < dayOfWeek.Length; m = m + 2)
{
    Console.WriteLine(dayOfWeek[m]); // zwr�ci pn sr pt nd
}

Console.ReadKey();