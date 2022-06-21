using ConceptsPOO;

Console.WriteLine("Hello, World!");

try
{
    Console.WriteLine(new Date(2000, 10, 7));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(2024, 11, 31));
}
catch (Exception error)
{

    Console.Write(error.Message);
}