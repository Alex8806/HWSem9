// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int PutInteger(char l)
{
    bool check = false;
    int num = -1;
    while (check == false | num < 0)
    {
        Console.WriteLine($"Задайте натуральное положительнео число {l}:");
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

int Akkerman (int m,int n){
    
  if (m == 0) return n + 1;
        if (n == 0) return Akkerman(m - 1, 1);
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = PutInteger('M');
int n = PutInteger('N');
Console.WriteLine($"Функция Аккермана для {m} и {n} равна {Akkerman(m,n)}");