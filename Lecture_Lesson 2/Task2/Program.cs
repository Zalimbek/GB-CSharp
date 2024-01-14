int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    // System.Console.WriteLine(arr[i]);
    // System.Console.WriteLine(' ');
    System.Console.Write($"{arr[i]} ");
    i = i + 1;
}
