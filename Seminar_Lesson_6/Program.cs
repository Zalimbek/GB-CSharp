// // Создать строку из массива символов

// string CharsToString (char[] chars)
// {
//     string str = "";
//     for (int i = 0; i < chars.Length; i++)
//     {
//         str+= chars[i];
//     } return str;
// }

// char[] chars = new char[]{'a', 'b', 'c', 'd'};
// System.Console.WriteLine(CharsToString(chars));

// //2 Method


// string str = new string(chars);
// System.Console.WriteLine(str);

// Метод, который из строки делает массив символов

// char[] StringToChars(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i=0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     } return chars;
// }

// void PrintChars(char[] chars)
// {
//     for (int i = 0; i < chars.Length; i++)
//     {
//         System.Console.Write($"{chars[i]} ");
//     }
// }
// string str = "Hello";
// PrintChars(StringToChars(str));
// //System.Console.WriteLine(StringToChars(str));

// Считать строку с консоли латинских букв, метод должен вычислять кол-во гласных.


int VowelsCnt(string str)
{
    int cnt = 0;
    char[] arr = {'a', 'e','i', 'o','u','y' };
     for (int i=0; i < str.Length; i++)
     {
       foreach (char e in arr)
       {
        if ( str[i]==e)
        {
            cnt++;
        }
       }  
     } return cnt;

}

System.Console.WriteLine("Type any word: ");
string input = Console.ReadLine().ToLower();
Console.WriteLine(VowelsCnt(input));