// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: " + num);
// Console.WriteLine($"{num} -> {num * num}");

// System.Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// //if(num1/num2 == num2)
// if(num1 == num2 * num2)
// {
//     Console.WriteLine($"{num1} is quad of {num2}");
// } else
// // {
// //     Console.WriteLine($"{num1} is not quad of {num2}");
// // }


// System.Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = -n; i < n; i++)
// {
//     System.Console.Write(i + " ");
// }

System.Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>= 99 && n<= 999)
{
    int first = n/100;
    int third = n%10;
    System.Console.WriteLine($"sum = {first + third}");
} else 
{
    System.Console.WriteLine("Not three digit number!");
}