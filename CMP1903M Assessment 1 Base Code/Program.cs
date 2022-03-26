//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Input;
using static CMP1903M_Assessment_1_Base_Code.Report;
using static CMP1903M_Assessment_1_Base_Code.Analyse;
using static CMP1903M_Assessment_1_Base_Code.LetterFreq;


namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            // List<int> parameters = new List<int>();
            List<int> values = null;
            string input = ("nothing");

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse a = new Analyse();
            Input p = new Input();

            // User Input
            Console.WriteLine("Do you want to enter the text via the keyboard? If so enter '1'. ");
            Console.WriteLine("Do you want to read in text from a file? If so enter '2'. ");

            // Option 1 or Option 2 Loop
            bool inputValid = true;
            do
            {
                try
                {
                    int inputChoice = Convert.ToInt32(Console.ReadLine());
                    if (inputChoice == 1)
                    {
                        inputValid = false;
                        input = p.manualTextInput();
                        values = a.analyseText(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter either '1' or '2'. ");
                    }
                }
                catch
                {
                    Console.WriteLine("Enter either '1' or '2'. ");
                }
            }
            while (inputValid == true);

            //Report the results of the analysis + Get the frequency of individual letters?
            Report r = new Report();
            int upperCount = r.upperCountMethod(values);
            int lowerCount = r.lowerCountMethod(values);
            int sentenceCount = r.sentenceCountMethod(values);
            int consonantCount = r.consonantCountMethod(values);
            int vowelCount = r.vowelCountMethod(values);

            Console.WriteLine("Number of Upper Case Letters : " + upperCount);
            Console.WriteLine("Number of Lower Case Letters: " + lowerCount);
            Console.WriteLine("Number of Sentences: " + sentenceCount);
            Console.WriteLine("Number of Consonant: " + consonantCount);
            Console.WriteLine("Number of Vowels: " + vowelCount);
            Console.WriteLine("Frequency of Indiviual Letters: ");

            // Analyse
            var analyse = new LetterFreq();

            //Results
            var anaysis = analyse.analyseText(input);

            var report = new Report();
            Console.WriteLine();


            //Frequency
            var frequency = analyse.letterFrequency(input);
            Console.WriteLine();
            //Outputting
            Console.WriteLine("Writing letter frequency:  ");
            Console.WriteLine();
            Console.WriteLine();
            //Print
            report.outputLetterFrequencyToConsole(frequency);
        }
    }
}