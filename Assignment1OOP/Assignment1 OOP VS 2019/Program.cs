using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();


            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input1 = new Input();
            
            string inputChoice = input1.ChoiceOfMethod();
            inputChoice.Contains("Manual");
            if (inputChoice.ToLower().Equals( "m" ) || (inputChoice.ToLower().Equals( "manual")))
            {
                string manualInput = input1.manualTextInput();
            }
            else if (inputChoice.ToLower().Equals( "f" ) || (inputChoice.ToLower().Equals( "file")))
            {
                string fileinput = input1.fileTextInput("");
            }
            else
            {
                Console.WriteLine("INVALID INPUT, PLEASE RE-ENTER YOUR INPUT.");
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyse1 = new Analyse();
            var analyse = analyse1.analyseText(inputChoice);
                

            //Receive a list of integers back



            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?
        }
    }
}
