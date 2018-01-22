using System;

public class Sentence_the_Thief
{
    public static void Main()
    {
        var numeralType = Console.ReadLine();
        var idsCount = int.Parse(Console.ReadLine());

        var thiefsID = long.MinValue;

        for (int i = 0; i < idsCount; i++)
        {
            var currentID = long.Parse(Console.ReadLine());

            switch (numeralType)
            {
                case "sbyte":
                    thiefsID = SByteTypeID(thiefsID, currentID);
                    break;

                case "int":
                    thiefsID = IntTypeID(thiefsID, currentID);
                    break;

                case "long":
                    thiefsID = LongTypeID(thiefsID, currentID);
                    break;
            }
        }

        var years = 0L;

        var sentence = CalculateSentenceOfTheThief(thiefsID, years);

        Console.WriteLine(sentence);
    }

    private static string CalculateSentenceOfTheThief(long thiefsID, long years)
    {
        var sentence = string.Empty;

        if (thiefsID >= 0)
        {
            years = (long)Math.Ceiling(Math.Abs((decimal)thiefsID / sbyte.MaxValue));
        }

        else
        {
            years = (long)Math.Ceiling(Math.Abs((decimal)thiefsID / sbyte.MinValue));
        }

        if (Math.Abs(years) <= 1)
        {
            sentence = $"Prisoner with id {thiefsID} is sentenced to {years} year";
        }

        else
        {
            sentence = $"Prisoner with id {thiefsID} is sentenced to {years} years";
        }

        return sentence;
    }

    private static long SByteTypeID(long thiefsID, long currentID)
    {
        long maxValue = sbyte.MaxValue;

        if (currentID > thiefsID && currentID <= maxValue)
        {
            thiefsID = currentID;
        }

        return thiefsID;
    }

    private static long IntTypeID(long thiefsID, long currentID)
    {
        long maxValue = int.MaxValue;

        if (currentID > thiefsID && currentID <= maxValue)
        {
            thiefsID = currentID;
        }

        return thiefsID;
    }

    private static long LongTypeID(long thiefsID, long currentID)
    {
        long maxValue = long.MaxValue;

        if (currentID > thiefsID && currentID <= maxValue)
        {
            thiefsID = currentID;
        }

        return thiefsID;
    }
}