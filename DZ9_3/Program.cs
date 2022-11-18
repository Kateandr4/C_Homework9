// Написать программу показывающие первые N чисел, для которых каждое 
//следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
void SumNum(int a, int b, int n)
{ 

 if (n>0) 
  {
    int sum=a+b;
    Console.Write(sum +" ");
    SumNum(b, sum, n-1);
  }
}

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());
int N = 5;
Console.Write(A+" ");
Console.Write(B+" ");
SumNum(A, B, N);