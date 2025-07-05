// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("C#"); //task0
// Console.WriteLine("Mano vardas Artur");// Task1
// // Task2 
// Console.Write("O koks tavo vardas: ");
// string? vardas = Console.ReadLine();
// Console.WriteLine($"Sveikas,{vardas}");

// //Task3 
// Console.WriteLine("Įvesk savo amžių;");
// string? input = Console.ReadLine();

// if (int.TryParse(input, out int age))
// {
//     Console.WriteLine($"Jūsų amžius: {age}");
//     if (age < 18)
//         Console.WriteLine("Nepilnametis");
//     else if (age < 65)
//         Console.WriteLine("Dar reikia eit į darbą");
//     else
//         Console.WriteLine("Nepasiseke");
// }
// else {
//     Console.WriteLine("Neteisingas formatas");
// }

// //Task4
// Console.WriteLine("Įvesk skaičių nuo 1 iki 10:"); // int 
// string? number1 = Console.ReadLine();

// if (int.TryParse(number1, out int result1))
// {
//     Console.WriteLine($"TAVO SKAIČIUS {result1}");
// }
// else
// {
//     Console.WriteLine("Neteisingas skaičius int formatui");
// }


// Console.WriteLine("Įvesk žodį:"); // string
// string? tekst1 = Console.ReadLine()?.ToUpper();
// Console.WriteLine($"TAVO ŽODIS '{tekst1}'");


// Console.WriteLine("Savo kūno temperatūrą:"); // double
// string? number2 = Console.ReadLine();
// number2 = number2?.Replace(',', '.');

// if (double.TryParse(number2, out double result2))
// {
//     Console.WriteLine($"TAVO TEMPERATŪRA {result2}");
// }
// else
// {
//     Console.WriteLine("Neteisingas skaičius double formatui");
// }

// Console.WriteLine("Ar šiandien šilta (t/n)? :"); // bool 
// string? tekst2 = Console.ReadLine()?.ToUpper();

// if (tekst2 == "T"|| tekst2 == "N" )
// {
//     bool jamšilta = tekst2 == "T";
//     Console.WriteLine(jamšilta
//     ? "TAIP, TAU ŠILTA!"
//     : "NE, TAU ŠALTA");
// }
// else
// {
//     Console.WriteLine("Neteisinga bool formatui");
// }


// string korta = "♦♣♠♥"; //char
// Console.WriteLine("Pasirink vieną 1 - ♦ / 2 - ♣ / 3 - ♠ / 4 - ♥:"); 
// string? number3 = Console.ReadLine();
// if (int.TryParse(number3, out int result3))
// {
//     if (1 == result3)
//     {
//         char simbolis = korta[0];
//         Console.WriteLine($"{simbolis}");
//     }
//     else if (2 == result3)
//     {
//           char simbolis = korta[1];
//         Console.WriteLine($"{simbolis}");
//     }
//     else if (3 == result3)
//     {
//           char simbolis = korta[2];
//         Console.WriteLine($"{simbolis}");
//     }
//     else if (4 == result3)
//     {
//           char simbolis = korta[3];
//         Console.WriteLine($"{simbolis}");
//     }

// }
// else
// {
//     Console.WriteLine("Neteisingas formatas");
// }


// //Task5
// Console.WriteLine("Įvesk savo vardą:");
// string? vardas1 = Console.ReadLine();

// Console.WriteLine("Įvesk savo amžių:");
// string? amžius = Console.ReadLine()?.ToUpper();
// if (int.TryParse(amžius, out int amžius2))
// {
//     if (amžius2 < 19)
//     {
//         Console.WriteLine($"{vardas1}, tau dar negalima balsuoti.");
//     }
//     else if (amžius2 < 66)
//     {
//         Console.WriteLine($"{vardas1}, tu gali balsuoti.");
//     }
//     else if (amžius2 > 65)
//     {
//         Console.WriteLine($"{vardas1}, tu esi pensinio amžiaus");
//     }
// }
// else
// {
//     Console.WriteLine("Įvestas neteisingas amžius.");
// }

// //Task 6 
// int n;
// Console.Write("Įveskite skaičių n: ");
// n = Convert.ToInt32(Console.ReadLine()); // greitas konvertavimas 
// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(i);
// }
// Console.Write("Task6 - Done ");

// //Task7
// Console.WriteLine("Įveskite skaičių (pvz.-100 iki 100); ");
// string? number4 = Console.ReadLine();
// if (int.TryParse(number4, out int rezult4))
// {
//     if (rezult4 < 0)
//     {
//         Console.WriteLine($"Skaičius {rezult4} yra neigiamas");
//     }
//     else if (rezult4 == 0)
//     {
//         Console.Write($"Skaičius {rezult4} yra nulis");
//     }
//     else if (rezult4 > 0)
//     {
//         Console.Write($"Skaičius {rezult4} yra teigiamas");
//     }
// }
// else
// {
//     Console.Write("ivestas neteisingas skaicius(int)");
// }


//Task8 
using System.Diagnostics;

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




