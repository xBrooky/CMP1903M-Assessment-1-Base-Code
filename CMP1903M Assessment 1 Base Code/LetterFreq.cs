using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class LetterFreq
    {
        public List<int> letterFrequency(string text)
        {
            var letter_count = new List<int>(new int[26]);
            var a_value = (int)'a';

            foreach (char ch in text)
            {
                if (char.IsWhiteSpace(ch) || !char.IsLetter(ch))
                {
                    continue;
                }

                var ch_clean = char.ToLower(ch);
                var ch_clean_value = (int)ch_clean;
                letter_count[ch_clean_value - a_value]++;

            }
            return letter_count;
        }

        public List<int> analyseText(string input)
        {

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }
            return values;
        }
    }
}
       
