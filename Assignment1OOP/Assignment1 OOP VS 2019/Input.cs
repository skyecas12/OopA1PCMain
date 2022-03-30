using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Again would remove these before handing in. Not needing them.

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
         
         //Have you tested to see if what happenes if they don't press f or m? Error might occur maybe put in a while loop so if response is not f or m
        //error is handled otherwise might break code.
        }
        public string manualTextInput()
        {
            Console.WriteLine("Please enter your manual text!: ");
            Console.Write("");
            text = Console.ReadLine();
            //What does this line do? ( Console.Write("") ) I'm sure you don't need this, will work without it
            //This could comeback as null so make sure you include string? text = Console.ReadLine()!;

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {

            Console.WriteLine("HI");           //Hi
            return text;
        }
    }
}
