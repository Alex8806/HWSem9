// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
int FromMtoN (int max,int min){
if (min==max) return min;
int sum = min + FromMtoN(max,min+1);
return sum;
}
int m = PutInteger('M');
int n = PutInteger('N');
int max;int min;
if (m>=n) {min=n;max=m;}
else {min =m;max=n;}
System.Console.WriteLine("Сумма натуральных элементов в промежутке : "+ FromMtoN(max,min));