using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_OOP_VS_2019
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        string[] Not_VowelLower = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s" };
        string[] Is_VowelLower = { "a", "e", "i", "o", "u" };
        string[] Upper_Vowel = { "A", "E", "I", "O", "U" };
        string[] Upper_Not_Vowel = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S" };
        string[] Sentence_Ends = { ",", "!", "?" };

        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int Sentence_Count = 0;
            //2. Number of vowels

            int Is_Vowel_Count = 0;
            //3. Number of consonants
            int Not_Vowel_Count = 0;

            //4. Number of upper case letters
            int Upper_Count = 0;
            //5. Number of lower ca4se letters
            int Lower_count = 0;

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'

            for (int i = 0; i < Is_Vowel_Count; i++) ;
            if (Upper_Vowel.Equals(Is_Vowel_Count++))
            {
                Is_Vowel_Count++;
            }

            for (int i = 0; i < Is_Vowel_Count; i++) ;
            if (Is_VowelLower.Equals(Is_Vowel_Count++))
            {
                Is_Vowel_Count++;
            }

            for (int i = 0; i < Upper_Count; i++) ;
            if (Upper_Vowel.Equals(Upper_Count++))
            {
                Upper_Count++;
            }

            for (int i = 0; i < Upper_Count; i++) ;
            if (Upper_Not_Vowel.Equals(Upper_Count++))
            {
                Upper_Count++;
            }

            for (int i = 0; i < Lower_count; i++) ;
            if (Not_VowelLower.Equals(Lower_count++))
            {
                Lower_count++;
            }

            for (int i = 0; i < Lower_count; i++) ;
            if (Is_VowelLower.Equals(Lower_count))
            {
                Lower_count++;
            }

            for (int i = 0; i < Not_Vowel_Count; i++) ;
            if (Upper_Not_Vowel.Equals(Not_Vowel_Count))
            {
                Not_Vowel_Count++;
            }

            for (int i = 0; i < Not_Vowel_Count; i++) ;
            if (Not_VowelLower.Equals(Not_Vowel_Count))
            {
                Not_Vowel_Count++;
            }

            for (int i = 0; i < Sentence_Count; i++) ;
            if (Sentence_Ends.Equals(Sentence_Count))
            {
                Sentence_Count++;
            }

            int Total_Letters = 0;

            Total_Letters = Lower_count + Upper_Count;



            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            values[0] = Lower_count;
            values[1] = Upper_Count;
            values[2] = Is_Vowel_Count;
            values[3] = Not_Vowel_Count;
            values[4] = Sentence_Count;
            Console.WriteLine(Lower_count);
            Console.WriteLine(Upper_Count);
            Console.WriteLine(Is_Vowel_Count);
            Console.WriteLine(Not_Vowel_Count);
            Console.WriteLine(Sentence_Count);
            Console.WriteLine(Total_Letters);
            return values;


        }
        
    }
}

