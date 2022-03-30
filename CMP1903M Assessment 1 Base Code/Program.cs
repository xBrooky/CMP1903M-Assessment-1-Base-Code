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

            Analyse newAnalyse = new Analyse();
            Input inputText = new Input();

            int inputChoice = inputText.handleInput();

            // Option 1 or Option 2 Loop
            bool inputValid = true;
            do
            {
                try
                {
                    if (inputChoice == 1)
                    {
                        inputValid = false;
                        input = inputText.manualTextInput();
                        values = newAnalyse.analyseText(input);
                        break;
                    }
                    else if (inputChoice == 2)
                    {
                        inputValid = false;
                        Console.WriteLine("Please Enter Path: ");
                        string fileLocation = Console.ReadLine();
                        input = inputText.fileTextInput(fileLocation);
                        values = newAnalyse.analyseText(input);
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

            // Analyse
            var analyse = new LetterFreq();

            //Results
            var analysis = analyse.analyseText(input);

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
            report.outputLetterFrequency(frequency);
        }
    }
}