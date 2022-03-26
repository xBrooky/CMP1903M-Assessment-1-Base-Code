using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            

            //Blank File
            string empty = ("Empty.txt");
            File.WriteAllText(empty, string.Empty);
            File.WriteAllText(empty, "Words with > 7 length");


            //The use of an asterisk (*) could indicate the end of the entry
            if (input.Contains('*'))
            {
                input = input.Substring(0, input.IndexOf("*"));
            }

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' || input[i] == '?' || input[i] == '!')
                    {
                        values[0]++;
                    }
            }

            //2. Number of vowels + //3. Number of consonants

            //Lower case conversion to count v + c
            string lowerCaseInput = input.ToLower();

            //Removing char to correctly counts values
            var charsToRemove = new String[] { ";", "'", ":", " ", "@", ",", "." };
            foreach (var c in charsToRemove)
            {
                lowerCaseInput = lowerCaseInput.Replace(c, string.Empty);
            }

            for (int i = 0; i < lowerCaseInput.Length; i++)
            {
                //Checks for Vowels
                if (lowerCaseInput[i] == 'a' || lowerCaseInput[i] == 'e' || lowerCaseInput[i] == 'i' || lowerCaseInput[i] == 'o' || lowerCaseInput[i] == 'u' || lowerCaseInput[i] == 'A' || lowerCaseInput[i] == 'E' || lowerCaseInput[i] == 'I' || lowerCaseInput[i] == 'O' || lowerCaseInput[i] == 'U')
                {
                    values[1]++;
                }
                //Checks for !Vowels - therefore Consonants
                if (lowerCaseInput[i] != 'a' || lowerCaseInput[i] != 'e' || lowerCaseInput[i] != 'i' || lowerCaseInput[i] != 'o' || lowerCaseInput[i] != 'u' || lowerCaseInput[i] != 'A' || lowerCaseInput[i] != 'E' || lowerCaseInput[i] != 'I' || lowerCaseInput[i] != 'O' || lowerCaseInput[i] != 'U')
                {
                    values[2]++;
                }
            }

            //4. Number of upper case letters + //5. Number of lower case letters
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*') break;
                if (char.IsLower(input[i])) values[3]++;
                if (char.IsUpper(input[i])) values[4]++;
            }



            //Split Section
            string[] wordList = input.Split(new Char[] { '.', ',', ' ', '!', '\n', '\t' });
            foreach (string word in wordList)
            {
                if (word.Trim() != "")
                {
                    if (word.Length > 7)
                    {
                        File.AppendAllText(empty, word);
                        File.AppendAllText(empty, "\n");
                    }
                }
            }
            return values;

        }
    }
}
