string[] StringToArray(string str)
{
    string[] array = new string[str.Length];
    array = str.Split(",");
    return array;
}

string[] FindElementsLess3 (string[] arr)
{
    int cnt = 0;
    foreach(string e in arr)
    {
        if (e.Length <= 3)
        {
            cnt = cnt+1;
        } 
    } 

    string[] newarr = new string[cnt];
    int j = 0;
     for (int i=0; i < arr.Length; i++)
    {
        
        if (arr[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        } 
    } return newarr;
}

void PrintArray(string[] arr)
{
    foreach(string e in arr)
    {
        Console.Write($"{e} ");
    }
}

//string[] array = {"Hello", "2", "world", ":-)"};
//PrintArray(FindElementsLess3(array));
Console.Write("Type any strings using , : ");
string FromConsole = Console.ReadLine();
string[] arrayFromConsole = StringToArray(FromConsole);
System.Console.WriteLine("You have entered: ");
PrintArray(arrayFromConsole);
System.Console.WriteLine("");
System.Console.WriteLine("The result is: ");
PrintArray(FindElementsLess3(arrayFromConsole));