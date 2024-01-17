// дано натуральное трехзначное число. создайте массив , состоящий из цифр этого числа, младший разряд
// этого числа должен располагаться на нулевом индексе массива 
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    System.Console.WriteLine(array[0]);
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] NumToArr(int num)
{
    if(num >= 100 && num <= 999)
    {
        int[] array = new int[3];
        int ed = num % 10;
        int dec = num / 10 % 10;
        int sot = num / 100;
        array[0] = ed;
        array[1] = dec;
        array[2] = sot;
        return array;
        
    }
    else
    {
        System.Console.WriteLine("You entered not 3 digit number!");
        return null;
    }

}
System.Console.WriteLine("Input 3 digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(NumToArr(num));