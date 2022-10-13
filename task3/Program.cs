/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine("Введите наименьшее из двух чисел");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее из двух чисел");
int M = Convert.ToInt32(Console.ReadLine());


void SumOfDigitsBetweenNM(int N, int M, int sum)
    {
        if (N > M) 
        {
            Console.WriteLine($"Сумма натуральных чисел между M и  N = {sum}");
        return;
        }
        sum = sum +(N++);
        SumOfDigitsBetweenNM(N,M,sum);
    }
SumOfDigitsBetweenNM(N,M,0);




