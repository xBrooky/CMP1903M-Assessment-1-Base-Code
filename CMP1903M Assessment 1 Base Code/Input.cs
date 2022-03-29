using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        public enum InputMode
        {
            Manual,
            TextFile,
        }

        string _text;
        public string text { get { return _text; } }

        InputMode _inputMode;
        InputMode inputMode { get { return _inputMode; } }

        public Input()
        {
            _inputMode = InputMode.Manual;
            _text = "";
        }

        //Handles the text input for Assessment 1
        //string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard

       //Public string manualTextInput()
       //
       //   Console.WriteLine("Please Enter Text: ");
       //   string text = Console.ReadLine();
       //   return text;
       //

        public string manualTextInput()
        {
            Console.WriteLine("Enter String: ");

            _text = Console.ReadLine();
            if (_text == null)
            {
                Console.WriteLine("Input can't be an empty string: ");
                return manualTextInput();
            }

            return _text;
        }

        public int handleInput()
        {

            // User Input
            Console.WriteLine("Do you want to enter the text via the keyboard? If so enter '1'. ");
            Console.WriteLine("Do you want to read in text from a file? If so enter '2'. ");

            string input = Console.ReadLine();
            int option = Convert.ToInt32(input);
            return option;

           
        }
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        // Program terminates if Error
        public string fileTextInput()
        {
            try
            {
                Console.WriteLine("Please enter file path: ");
                string path = Console.ReadLine();
                string text = File.ReadAllText(path);
                return text;

            }
            catch
            {
                Console.WriteLine("File not found, Error");
                return fileTextInput();
            }
        }
    }
}
