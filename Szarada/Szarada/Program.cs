Kurs Adama Lekcja 5 TABLICE, PÊTLA FOR Z TABLICAMI

int[] grades = new int[365];
string[] dayOfWeek = new string[7];

// PIERWSZY WZÓR

dayOfWeek[0] = "pn";
dayOfWeek[1] = "wt";
dayOfWeek[2] = "sr";
dayOfWeek[3] = "cz";
dayOfWeek[4] = "pt";
dayOfWeek[5] = "sb";
dayOfWeek[6] = "nd";

Console.WriteLine(dayOfWeek[2]); // zwróci sr

// DRUGI WZÓR

string[] week = 
         { " pn", "wt", "sr", " cz", "pt", "sb", "nd" };

Console.WriteLine(); // oddziela linie - pomijane dalej

Console.WriteLine(week[6]); // zwróci nd


for (int i = 0; i < 7; i++)
{
    Console.WriteLine("[i]"); // zwróci 7x[i]
}


for (int j = 0; j < 7; j++)
{
    Console.WriteLine(j); // zwróci 0 1 2 3 4 5 6
}

// ZABAWA Z PÊTL¥

// Poni¿sza pêtla wyœwietli pn wt sr cz pt sb nd. Ale zasada jest taka, ¿e wiemy, ¿e g < 7

for (int g = 0; g < 7; g++)
{
    Console.WriteLine(dayOfWeek[g]); 
}

// Ale nie zawsze musimy wiedzieæ, od ilu g musi byæ mniejsze(drugi slot, druga przestrzeñ). Gdyby ktoœ kiedyœ w kodzie wyjœciowym coœ zmieni³, ¿e np k < 1000, to Lenght rozwi¹zuje ten problem

for (int k = 0; k < dayOfWeek.Length; k = k + 1)
{
    Console.WriteLine(dayOfWeek[k]); 
                         // zwróci pn wt sr cz pt sb nd
}


for (int m = 0; m < dayOfWeek.Length; m = m + 2)
{
    Console.WriteLine(dayOfWeek[m]); // zwróci pn sr pt nd
}

Console.ReadKey();