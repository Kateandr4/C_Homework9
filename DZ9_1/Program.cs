// Показать натуральные числа от M до N, N и M заданы

void PrintNum(int m, int n)
{
if(n>=m)
{
    Console.Write(n+ " ");
    PrintNum(m, n-1);
}
}
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N, больше M");
int N = int.Parse(Console.ReadLine());
PrintNum(M, N);
