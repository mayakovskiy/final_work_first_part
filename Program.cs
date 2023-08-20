﻿string [] CreateArray ()
{
    Console.Clear();
    int size = 10;
    int count = 0;
    string[] arrayToCreate = new string[size];
    Console.WriteLine("Enter any words, numbers, symbols: ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Press ENTER to continue or Type \"end\" to stop entering:  ");
        string enteredData = Console.ReadLine()!;
        if (enteredData == "end")
        {
            break;
        }
        arrayToCreate[i] = enteredData;
        count++;
    }
    Array.Resize(ref arrayToCreate, count);
    return arrayToCreate;
}

string PrintArray (string [] arrayToPrint)
{
    string result = $"[{string.Join(", ", arrayToPrint.Select(x => $"\"{x}\""))}]";
    return result;
}

string [] ChangeArray(string[] arrayToModify)
{
    string [] resultArr = new string [arrayToModify.Length];
    int count = 0;
    foreach (string word in arrayToModify)
    {
        if (word.Length <= 3)
        {
            resultArr[count] = word;
            count++;
        }
    }
    Array.Resize(ref resultArr, count);
    return resultArr;
}

string[] array = CreateArray();
string[] resultArray = ChangeArray(array);
Console.Write(PrintArray(array) + " -> " + PrintArray(resultArray));