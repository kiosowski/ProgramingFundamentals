using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var nucleicSequences = new char[] { 'A', 'C', 'G', 'T' };
            var nucleicValues = new int[] { 1, 2, 3, 4 };

            var sequence = string.Empty;

            var matchSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        var firstNucleotide = nucleicSequences[i];
                        var secondNucleotide = nucleicSequences[j];
                        var thirdNucleotide = nucleicSequences[k];

                        var currentSum = nucleicValues[i] + nucleicValues[j] + nucleicValues[k];

                        var symbol = "X";

                        if (currentSum >= matchSum)
                        {
                            symbol = "O";
                            sequence = symbol + firstNucleotide + secondNucleotide + thirdNucleotide + symbol;
                        }

                        else
                        {
                            sequence = symbol + firstNucleotide + secondNucleotide + thirdNucleotide + symbol;
                        }

                        Console.Write(sequence + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}