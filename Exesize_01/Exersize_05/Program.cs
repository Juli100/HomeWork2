Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine());

int index = 1;
int work = 1;

while (index <= N)
{
    work = work * index;
    index++;
}
Console.WriteLine($"произведение чисел от 1 до {N} = {work}");