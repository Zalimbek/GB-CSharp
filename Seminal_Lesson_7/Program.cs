// на вход подается число, получаем сумму его цифр - рекурсия

// using System.Runtime.InteropServices;

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return num % 10 + FindSum(num / 10);
//     }
//     return 0;

// }

// Console.WriteLine(FindSum(456));

// Задайте значение N. Напишите программу, которая выводит все натуральные числа в промежутке от 1 до N

// void OneToN(int n)
// {
//     if (n > 0)
//     {
//         OneToN(n-1);
//         System.Console.WriteLine(n + " ");
//     }
    
// }

// System.Console.Write("Ennter any valye N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// OneToN(N);

// Считать строку с консоли, содержащую латинские буквы. Вывести на экран латинские буквы этой строки


void Sogl(string str, int i)
{
    if (i == str.Length)
    return;
    if (str[i] >= 'a' && str[i] <= 'z' && "aeiou".IndexOf(str[i])== -1)
    {
        System.Console.Write(str[i]);
    }
    Sogl(str, i+1);
}


string str = Console.ReadLine();
Sogl(str, 0);