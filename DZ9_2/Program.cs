// Найти сумму элементов от M до N, N и M заданы
int SumNum(int m, int n)
{
    if(n<m) return 0;
    return  SumNum(m, n-1)+n;

}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N, больше числа M");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("сумма элементов от M до N");
Console.WriteLine(SumNum(M, N));