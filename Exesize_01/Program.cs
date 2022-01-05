Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "0");
for (int i = 1; i <= N; i++)
 //i <= k; i++)
{
    Console.WriteLine($"{i} = {i * i * i}");
}

