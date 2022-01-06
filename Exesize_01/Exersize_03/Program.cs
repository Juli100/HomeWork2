Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine());

int index = 1;
int sum = 0;

while (index <= N)
{
    sum = sum + index;
    index++;
}
Console.WriteLine($"сумма чисел от 1 до {N} = {sum}");