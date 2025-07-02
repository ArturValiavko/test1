// See https://aka.ms/new-console-template for more information
Console.WriteLine("C#"); //task1 
Console.WriteLine("Mano vardas Artur");

Console.WriteLine("Sveikas C#");

Console.Write("O koks tavo vardas: ");
string vardas = Console.ReadLine();
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
