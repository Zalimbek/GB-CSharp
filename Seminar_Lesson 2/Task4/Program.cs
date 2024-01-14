// на вход 2 числа и выводить , является ли второе число кратным первому. Если число не кратно первому,
// то программа выврдит остаток от деления

void isDelete(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        System.Console.WriteLine($"The second number {num2} is a multiple of {num1}");
    }
    else
    {
        System.Console.WriteLine($"The second number {num2} is not a multiple of {num1}. Remainder is {num1 % num2}");
    }
}
System.Console.WriteLine("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
isDelete(number1, number2);