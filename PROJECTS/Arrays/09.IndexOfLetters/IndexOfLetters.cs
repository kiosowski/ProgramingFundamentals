﻿using System;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        char[] arr = new char[26];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (char)('a' + i);
        }
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i] + " -> " + Array.IndexOf(arr, word[i]));
        }
    }
}