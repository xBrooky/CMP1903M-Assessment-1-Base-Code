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

        public void manualTextInput()
        {
            _text = Console.ReadLine();
            if (text == null)
            {
                _text = "";
            }
        }

        public void handleInput()
        {
            switch (_inputMode)
            {
                case InputMode.Manual:
                    Console.WriteLine("Please Enter Text: ");
                    manualTextInput();
                    break;  
            }
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
                string text = File.ReadAllText("WriteText.txt");
                return text;

            }
            catch
            {
                Console.WriteLine("File not found, Error");
                Environment.Exit(0);
                return null;
            }
        }
    }
}
