//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());


void SumNumbers (int N, int M, int sum) {
    if (M > N) {
        Console.WriteLine("Сумма натуральных чисел равна: " + sum);
        return;
    }
    sum = sum + (M++);
    SumNumbers(N, M, sum);
}
SumNumbers(N, M, 0);