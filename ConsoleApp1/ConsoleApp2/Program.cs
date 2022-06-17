using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        //Declarations
        List<string> values = new List<string>();
        string x;

      
        Console.Write("Insert number of strings:");
        x = Console.ReadLine();

        for (int i = 0; i < Int32.Parse(x); i++){
            Console.Write(string.Concat("String N° ", i+1,":"));
            values.Add(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Processing...");
        Console.WriteLine();

        sortingOperations(values);

    }

    public static void sortingOperations(List<String> values)
    {
        string sortedvalue;
        string newsortedvalue;
        int numchar;

        int ValueMax;
        int IndexMax;

        int AsciiVal;

        char character;

        int[] freqarray = new int[26];


        foreach (string value in values)
        {
            sortedvalue = value;
            numchar = sortedvalue.Length;
            newsortedvalue = "";

            for (int i = 0; i < numchar; i++)
            {
                freqarray[sortedvalue[i] - 'a']++;
            }

            while (numchar > 0)
            {
                ValueMax = freqarray.Max();
                IndexMax = Array.IndexOf(freqarray, ValueMax);

                AsciiVal = IndexMax + 97;
                character = (char)AsciiVal;

                newsortedvalue = newsortedvalue + new string(character, ValueMax);

                freqarray[IndexMax] = 0;

                numchar = numchar - ValueMax;
            }

            Console.WriteLine(newsortedvalue);
        }

        Console.WriteLine();
        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
    }

}
