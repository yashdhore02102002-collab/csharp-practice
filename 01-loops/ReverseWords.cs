using System;

class ReverseWordsManual
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string result = "";
        string word = "";

        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            char ch = sentence[i];

            if (ch != ' ')
            {
                word = ch + word;   // character word च्या पुढे जोड
            }
            else
            {
                if (word != "")
                {
                    result = result + word + " ";
                    word = "";
                }
            }
        }

        // शेवटचा (सुरुवातीचा) word add कर
        if (word != "")
        {
            result = result + word;
        }

        Console.WriteLine("Reversed sentence: " + result);
    }
}