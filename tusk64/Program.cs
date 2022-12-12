// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int PositiveInteger()
{
    bool check = false;
    int num = -1;
    while (check == false | num < 0)
    {
        Console.WriteLine("Задайте натуральное положительнео число :");
        check = int.TryParse(Console.ReadLine(), out num);
        if (check == false)
        {
            System.Console.WriteLine("Вы ввели не натуральное число!");
            continue;
        }
        if (num < 0)
        {
            System.Console.WriteLine("Вы ввели отрицательное число!");
            continue;
        }
    }
    return num;
}

void NumFromNto1(int n)
{

    if (n == 1) {
    Console.Write($"{n} ");
    return;}

    Console.Write($"{n}, ");
    NumFromNto1(n - 1);
}
int n = PositiveInteger();
NumFromNto1(n);
