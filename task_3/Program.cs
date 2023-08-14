// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

int Ackerman(int m, int n) {
    if (m == 0) 
        return n + 1;
    else if (n == 0) 
        return Ackerman(m - 1, 1);
    else 
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

int InputNumbers(string text) {
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FunctionAkkerman = Ackerman(m, n);

Console.Write("Функция Аккермана = " + FunctionAkkerman);