//int kub = new Random().Next(1, 10);
Console.WriteLine("введите число: ");
int kub = int.Parse(Console.ReadLine());
Console.WriteLine($"{kub} = {kub * kub * kub}");
int N = kub;
if ( N % 2 == 0 )
{
    Console.WriteLine("куб числа четное");
}
if (N % 2 == 1)
{
    Console.WriteLine("не четное ");
}
