// // Принимает на вход трехзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре

// double secondToThird(int num)
// {
//     if(num > 99 && num <= 999)
//     { 
//         int ed = num % 10;
//         int dec = (num/10) % 10;
//         return (int)Math.Pow(dec, ed);
//     }
//     return 0;
// }
// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(secondToThird(number));

// напишем функцию сами

int secondToThird(int num)
{
    if(num > 99 && num <= 999)
    { 
        int ed = num % 10;
        int dec = (num/10) % 10;
        int result = dec;
        for (int i = 0; i < ed-1; i++)
        {
            result = result * dec;
        }
        return result;
    }
    return 0;
}
System.Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(secondToThird(number));