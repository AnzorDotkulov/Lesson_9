// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

void NaturalNumbers (int N) {
    if (N < 0) {
        Console.WriteLine("Вы ввели не натуральное число!");
    }
    if (N == 0) {
        return;
    }
    Console.Write(N + " ");
    NaturalNumbers(N - 1);
}
NaturalNumbers(N);