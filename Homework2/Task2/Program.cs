Console.Write("Type the first coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Type the second coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

//Console.Write("Type coordinates X and Y with a space: ");
// string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt31(coordinates[1]);

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Incorrect coordinates!");
}
