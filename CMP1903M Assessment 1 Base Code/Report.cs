using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Analyse;
using static CMP1903M_Assessment_1_Base_Code.LetterFreq;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        //Sentence
        public int sentenceCountMethod(List<int>values)
        {
            int sentenceCount = values[0];
            return sentenceCount;
        }

        //Vowel
        public int vowelCountMethod(List<int> values)
        {
            int vowelCount = values[1];
            return vowelCount;
        }

        //Consonant
        public int consonantCountMethod(List<int> values)
        {
            int consonantCount = values[2];
            return consonantCount;
        }

        //Lower Case
        public int lowerCountMethod(List<int> values)
        {
            int lowerCount = values[3];
            return lowerCount;
        }

        //Upper Case
        public int upperCountMethod(List<int> values)
        {
            int upperCount = values[4];
            return upperCount;
        }

        //Frequency
        public void outputLetterFrequency(List<int> frequency)
        {
            Console.WriteLine("Frequency of Indiviual Letters: ");
            Console.WriteLine(letterFrequencyToReport(frequency));
            
        }

        //Convert frequency list to readable
        static string letterFrequencyToReport(List<int> frequency)
        {
            var a_value = (int)'a';
            var frequency_string = new List<string>();
      
            for (int i = 0; i < frequency_string.Count; i++)
            {
                var ch = (char)(i + a_value);
                var count = frequency[i];

                frequency_string.Add(char.ToUpper(ch) + ": " + count);
            }
            return string.Join(", ", frequency_string);
        }
    }
}
