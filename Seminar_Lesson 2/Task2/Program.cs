// на вход трехзначное число, удаляем вторую цифру
using System.ComponentModel;

void deteleSecondDigit(int num)
{
    if(num > 99 && num <= 999)
    { 
        System.Console.WriteLine($"{num} -> {num/100 * 10 + num % 10}");
    }
    else
    {
        System.Console.WriteLine("The input not 3 digit number!");
    }
}
System.Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
deteleSecondDigit(number);