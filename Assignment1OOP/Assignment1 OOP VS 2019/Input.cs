using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string ChoiceOfMethod()
        {
            Console.WriteLine("Please enter your preferred method of input: ");
            Console.WriteLine("Press f, or type file for file input: ");
            Console.WriteLine("Press m, or type manual for manual text input");
            Console.Write("");
            text = Console.ReadLine();

            return text;
        }
        public string manualTextInput()
        {
            Console.WriteLine("Please enter your manual text!: ");
            Console.Write("");
            text = Console.ReadLine();

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {

            Console.WriteLine("HI");
            return text;
        }
    }
}
