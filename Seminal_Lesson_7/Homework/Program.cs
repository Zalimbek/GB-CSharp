// void ValuesInRange(int m, int n) // 2 - 8
// {
//     if (n > 0 && n >= m)
//     {
//         ValuesInRange(m, n-1);
//         System.Console.WriteLine(n + " ");
//     }

// }

// System.Console.Write("Enter start valye M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter end valye N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ValuesInRange(M, N);

// using System.Runtime.InteropServices;

// int Akkerman(int m, int n)
//     {
//         if (m < 0 || n < 0) 
//         {
//             System.Console.WriteLine("M and N must be positive!");
//         }
//         if (m == 0)
//         {
//             return n + 1;
//         } 
        
//         if (n == 0) 
//         {
//             return Akkerman(m - 1, 1);
//         } else
//         {
//             return Akkerman(m - 1, Akkerman(m, n - 1));
//         }
//     }
// System.Console.Write("Enter start valye M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter end valye N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Akkerman(M, N));


void ArrayViceVersa(int[] arr, int i)
{
    if (i == arr.Length)
    return;

    ArrayViceVersa(arr, i+1);
    System.Console.Write(arr[i] + " ");
}
int[] array = {1, 2, 5,0, 10,34};
ArrayViceVersa(array, 0);

