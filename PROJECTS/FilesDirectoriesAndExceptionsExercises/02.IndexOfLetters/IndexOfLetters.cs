using System;
using System.IO;
class IndexOfLetters
{
    static void Main()
    {
        string word = File.ReadAllText("input.txt");
        char[] arr = new char[26];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (char)('a' + i);
        }
        for (int i = 0; i < word.Length; i++)
        {

            File.AppendAllText("output.txt", (word[i] + " -> " + Array.IndexOf(arr, word[i]) + Environment.NewLine));
        }
    }
}