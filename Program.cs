﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("C#"); //task0
Console.WriteLine("Mano vardas Artur");// Task1
// Task2 
Console.Write("O koks tavo vardas: ");
string? vardas = Console.ReadLine();
Console.WriteLine($"Sveikas,{vardas}");

//Task3 
Console.WriteLine("Įvesk savo amžių;");
string? input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"Jūsų amžius: {age}");
    if (age < 18)
        Console.WriteLine("Nepilnametis");
    else if (age < 65)
        Console.WriteLine("Dar reikia eit į darbą");
    else
        Console.WriteLine("Nepasiseke");
}
else {
    Console.WriteLine("Neteisingas formatas");
}

//Task4
Console.WriteLine("Įvesk skaičių nuo 1 iki 10:"); // int 
string? number1 = Console.ReadLine();

if (int.TryParse(number1, out int result1))
{
    Console.WriteLine($"TAVO SKAIČIUS {result1}");
}
else
{
    Console.WriteLine("Neteisingas skaičius int formatui");
}


Console.WriteLine("Įvesk žodį:"); // string
string? tekst1 = Console.ReadLine()?.ToUpper();
Console.WriteLine($"TAVO ŽODIS '{tekst1}'");


Console.WriteLine("Savo kūno temperatūrą:"); // double
string? number2 = Console.ReadLine();
number2 = number2?.Replace(',', '.');

if (double.TryParse(number2, out double result2))
{
    Console.WriteLine($"TAVO TEMPERATŪRA {result2}");
}
else
{
    Console.WriteLine("Neteisingas skaičius double formatui");
}

Console.WriteLine("Ar šiandien šilta (t/n)? :"); // bool 
string? tekst2 = Console.ReadLine()?.ToUpper();

if (tekst2 == "T"|| tekst2 == "N" )
{
    bool jamšilta = tekst2 == "T";
    Console.WriteLine(jamšilta
    ? "TAIP, TAU ŠILTA!"
    : "NE, TAU ŠALTA");
}
else
{
    Console.WriteLine("Neteisinga bool formatui");
}


string korta = "♦♣♠♥"; //char
Console.WriteLine("Pasirink vieną 1 - ♦ / 2 - ♣ / 3 - ♠ / 4 - ♥:"); 
string? number3 = Console.ReadLine();
if (int.TryParse(number3, out int result3))
{
    if (1 == result3)
    {
        char simbolis = korta[0];
        Console.WriteLine($"{simbolis}");
    }
    else if (2 == result3)
    {
          char simbolis = korta[1];
        Console.WriteLine($"{simbolis}");
    }
    else if (3 == result3)
    {
          char simbolis = korta[2];
        Console.WriteLine($"{simbolis}");
    }
    else if (4 == result3)
    {
          char simbolis = korta[3];
        Console.WriteLine($"{simbolis}");
    }

}
else
{
    Console.WriteLine("Neteisingas formatas");
}


//Task5
Console.WriteLine("Įvesk savo vardą:");
string? vardas1 = Console.ReadLine();

Console.WriteLine("Įvesk savo amžių:");
string? amžius = Console.ReadLine()?.ToUpper();
if (int.TryParse(amžius, out int amžius2))
{
    if (amžius2 < 19)
    {
        Console.WriteLine($"{vardas1}, tau dar negalima balsuoti.");
    }
    else if (amžius2 < 66)
    {
        Console.WriteLine($"{vardas1}, tu gali balsuoti.");
    }
    else if (amžius2 > 65)
    {
        Console.WriteLine($"{vardas1}, tu esi pensinio amžiaus");
    }
}
else
{
    Console.WriteLine("Įvestas neteisingas amžius.");
}

//Task 6 
int n;
Console.Write("Įveskite skaičių n: ");
n = Convert.ToInt32(Console.ReadLine()); // greitas konvertavimas 
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}
Console.Write("Task6 - Done ");

//Task7
Console.WriteLine("Įveskite skaičių (pvz.-100 iki 100); ");
string? number4 = Console.ReadLine();
if (int.TryParse(number4, out int rezult4))
{
    if (rezult4 < 0)
    {
        Console.WriteLine($"Skaičius {rezult4} yra neigiamas");
    }
    else if (rezult4 == 0)
    {
        Console.Write($"Skaičius {rezult4} yra nulis");
    }
    else if (rezult4 > 0)
    {
        Console.Write($"Skaičius {rezult4} yra teigiamas");
    }
}
else
{
    Console.Write("ivestas neteisingas skaicius(int)");
}


//Task8 

Console.WriteLine("Įvesk pažimį:");
string? number5 = Console.ReadLine();
int.TryParse(number5, out int rezult5);

switch (rezult5)
{
    case 1:
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Nepatenkinamai");
        break;
    case 5:
    case 6:
        Console.WriteLine("Patenkinamai");
        break;
    case 7:
    case 8:
        Console.WriteLine("Gerai");
        break;
    case 9:
    case 10:
        Console.WriteLine("Puikiai");
        break;
    case 0:
        Console.WriteLine("neteisingas formatas");
        break;       
}

//Task9

Console.WriteLine("Įvesk skaičių A:");
string? a1 = Console.ReadLine();
int.TryParse(a1, out int a);

Console.WriteLine("Įvesk skaičių B:");
string? b1 = Console.ReadLine();
int.TryParse(b1, out int b);

int Sum = (a + b);
int skirt = (a - b);
int daug = (a * b);
if (a != 0)
{
    if (b != 0)
    {
        int dalyb = (a / b);
        Console.WriteLine($"Dalyba:{dalyb}");
    }
    else
    {
        Console.WriteLine("Dalyba iš nulio negalima! (b = 0)");
    }
}
else
{
    Console.WriteLine("Dalyba iš nulio negalima! (A = 0)");
}

Console.WriteLine($"Suma:{Sum}");
Console.WriteLine($"Skirtumas:{skirt}");
Console.WriteLine($"Daugyba:{daug}");

//Task10
Console.WriteLine("Įvesk skaičių A:");
string? num1 = Console.ReadLine();
if (!int.TryParse(num1, out int lyginimas1))
{
    Console.WriteLine("Neteisingas skaičius A");
    return;
}

Console.WriteLine("Įvesk skaičių B:");
string? num2 = Console.ReadLine();
if (!int.TryParse(num2, out int lyginimas2))
{
      Console.WriteLine("Neteisingas skaičius B");
    return;
}



if (lyginimas1 > lyginimas2)
{
    Console.WriteLine($"Skaičius A = {lyginimas1} yra didesnis už skaičių B = {lyginimas2} ");
}
if (lyginimas1 == lyginimas2)
{
    Console.WriteLine($"Skaičiai A = {lyginimas1} ir B = {lyginimas2} yra lygus");
}
if (lyginimas1 < lyginimas2)
{
    Console.WriteLine($"Skaičius B = {lyginimas2} yra didesnis už skaičių A = {lyginimas1}");
}


//Task11

Console.WriteLine("Įvesk amžių");
string? num3 = Console.ReadLine();

if (int.TryParse(num3, out int result4))
{
    if (result4 < 0)
    {
        Console.WriteLine($"{result4} įvestas blogas skaičius");
    }
    else if (result4 < 13)
    {
        Console.WriteLine($"{result4} metų - Vaikas");
    }
    else if (result4 < 18)
    {
        Console.WriteLine($"{result4} metų - Paauglys");
    }
    else if (result4 < 65)
    {
        Console.WriteLine($"{result4} metų - Suaugęs");
    }
    else 
    {
        Console.WriteLine($"{result4} metų - Senjoras");
    }

}
else
{
    Console.WriteLine($"Neteisingas formatas");
}


//Task12 

Console.WriteLine("Įvesk skaičiu, kiek kartu bus kartojama programa");
string? num4 = Console.ReadLine();

if (int.TryParse(num4, out int kartok))
{
    for (int i = 1; i <= kartok; i++) // kartok + 1 veikia taip pat. 
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}


//Taks13

int inppass = 0 ;
int pass = 1234;

  Console.WriteLine("Pabandyk atspėti mano pin (pvz. 1234)");
string? input1 = Console.ReadLine();

int.TryParse(input1, out int pass1);
inppass = pass1;
//Console.WriteLine((pass, pass1, inppass));

while (pass != inppass)
{
    Console.WriteLine("Pabandyk dar karta atspėti mano pin (pvz. 1234)");
    string? input2 = Console.ReadLine();
    int.TryParse(input2, out int pass2);
    inppass = pass2;
    //Console.WriteLine((pass, pass2, inppass));
}
//task 13.1 teisingesnis 
/*
  int pass = 1234;
  int inppass = 0;

        while (inppass != pass)
        {
            Console.WriteLine("Pabandyk atspėti mano PIN (pvz. 1234):");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out inppass))
            {
                Console.WriteLine("Blogas formatas! Įveskite skaičių.");
                continue;
            }
        }
 Console.WriteLine("Sveikiname! Teisingas PIN.");   
*/
//task14 
int summ = 0;
int nenulis;
do
{
    Console.WriteLine("įrašyk skaičių, jie bus sudėti");
    string? input3 = Console.ReadLine();
    int.TryParse(input3, out int nenulis1);
    nenulis = nenulis1;
    summ = summ + nenulis;
} while (nenulis != 0);
Console.WriteLine($"Rezultatas = {summ}");

Console.WriteLine("C# pagrindų pabaiga");