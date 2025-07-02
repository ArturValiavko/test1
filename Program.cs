// See https://aka.ms/new-console-template for more information
Console.WriteLine("C#"); //task0
Console.WriteLine("Mano vardas Artur");
// Task1
Console.WriteLine("Sveikas C#");
// Task2 
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
Console.WriteLine("taks3 gwf");
//