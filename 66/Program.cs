// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int n = int.Parse(Console.ReadLine()!);
 
void GapNumberSum (int num1, int num2, int sum)
{
    if (num1 > num2) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (num1++);
    GapNumberSum(num1, num2, sum);
}

GapNumberSum(m, n, 0);