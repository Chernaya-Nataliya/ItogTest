using System;
using static System.Console;

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int a) 
{
    string[] output = new string[CountLessThan(input, a)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= a) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int a) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= a) 
        {
            count++;
        }
    }

    return count;
}

string[] AskArray() 
{
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}