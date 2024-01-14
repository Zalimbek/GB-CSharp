// void numToQuad(int num)
// {
//    System.Console.WriteLine($"Quad is: {num * num}");
// }
// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// numToQuad(number);

// Not void method
int numToQuad2(int num)
{
   return num * num;
}
System.Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(numToQuad2(number));