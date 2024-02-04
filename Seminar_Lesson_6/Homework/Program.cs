// // Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// string CharsToString(char[,] chars)
// {
//     string str = "";
//     for (int i = 0; i < chars.GetLength(0); i++)
//     {
//         for (int j = 0; j < chars.GetLength(1); j++)
//         {
//             str += chars[i,j]; 
//         }
//     } return str;

// }

// char[,] inputStr = {{'q','w','e'},{'a','s','d'}};
// System.Console.WriteLine(CharsToString(inputStr));

// Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// System.Console.WriteLine("Type any word: ");
// string input = Console.ReadLine().ToLower();
// Console.WriteLine(input);

// Задайте произвольную строку. Выясните, является ли она палиндромом.

 bool Palindrom(string str)

 {
     string letters= new string(str.Where(char.IsLetterOrDigit).ToArray()); 
     //string letters_rev = string.letters.Reverse();
     System.Console.WriteLine(letters.Reverse());
        for(int i = 0; i < letters.Length; i++)
            if(letters[i] != letters[letters.Length - i - 1]) 
            {
                return false;
            } return true;
        
            
        }
 

System.Console.WriteLine("Type any word: ");
string input = Console.ReadLine().ToLower();
System.Console.WriteLine(Palindrom(input));