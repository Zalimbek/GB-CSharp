// void ABC()
// {
//     int num = new Random().Next(10, 99 + 1);
//     System.Console.WriteLine(num);
// }

// ABC();

// Задача 1: Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// void isMultiple(int num1)
// {
//     if (num1 % 7 == 0 && num1 % 23 == 0)
//     {
//         System.Console.WriteLine($"The number {num1} is a multiple of 7 and 23");
//     }
//     else
//     {
//         System.Console.WriteLine($"The number {num1} is not a multiple of 7 and 23");
//     }
// }
// System.Console.WriteLine("Input number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// isMultiple(number1);

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// void coordQuarter(float X, float Y)
// {
//     if (X != 0 && Y != 0)
//     {
//         if (X > 0 && Y > 0)
//         {
//             System.Console.WriteLine("The point is located in 1st quarter");
//         }
//         else if (X < 0 && Y > 0)
//         {
//              System.Console.WriteLine("The point is located in 2nd quarter");
//         }
//          else if (X < 0 && Y < 0)
//         {
//              System.Console.WriteLine("The point is located in 3rd quarter");
//         }
//         else 
//         {
//             System.Console.WriteLine("The point is located in 4th quarter");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("X or Y are 0!");
//     }
// }

// System.Console.WriteLine("Input X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// coordQuarter(X, Y);

//Задача 3: Напишите программу, 
//которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

//  void maxDigit()
//  {
//      int num = new Random().Next(10, 99 + 1);
//      int ed = num / 10;
//      int dec = num % 10;
//      if (ed > dec)
//      {
//         System.Console.WriteLine($"{ed} is bigger than {dec} in the number {num}");
//      }
//      else if (ed < dec)
//      {
//          System.Console.WriteLine($"{dec} is bigger than {ed} in the number {num}");
//      }
//      else 
//      {
//         System.Console.WriteLine($"{dec} is equal to {ed} in the number {num}");
//      }
//  }

// maxDigit();

// Задача 4: Напишите программу, 
//которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
void digitWithComma(string num)
{
    char[] ch = num.ToCharArray();

    for (int i = 0; i <= ch.Length - 1; i++)
    {
        if (i < ch.Length-1)
        {
            System.Console.Write(ch[i]);
            System.Console.Write(", ");
        }
        else 
        {
            System.Console.Write(ch[i]);
        }
        
    }
    
}
System.Console.WriteLine("Input any number: ");
string number = Console.ReadLine();
digitWithComma(number);