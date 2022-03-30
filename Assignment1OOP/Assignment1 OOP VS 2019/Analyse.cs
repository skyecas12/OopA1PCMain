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
        char[] Not_VowelLower = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'y', 'v', 'x', 'z', 'w' };
        char[] Is_VowelLower = { 'a', 'e', 'i', 'o', 'u' };
        char[] Upper_Vowel = { 'A', 'E', 'I', 'O', 'U' };
        char[] Upper_Not_Vowel = { 'B', 'C', 'D', 'f', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'Y', 'V', 'X', 'Z', 'W' };
        char[] Sentence_Ends = { '.', '!', '?' };
        char[] Space_Between_Words = { ' ' };
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
            int Total_Letters = 0;
            int space_words = 0;
            bool exist = false;
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'


            foreach (char ch in input)
            {
                if (Upper_Not_Vowel.Contains(ch))
                {
                    Upper_Count++;
                    Not_Vowel_Count++;
                    exist = true;    
                }
            }

            foreach (char ch in input)
            {
                if (Upper_Vowel.Contains(ch))
                {
                    Upper_Count++;
                    Is_Vowel_Count++;
                    exist = true; 
                }
            }

            foreach (char ch in input)
            {
                if (Is_VowelLower.Contains(ch))
                {
                    Lower_count++;
                    Is_Vowel_Count++;
                    exist = true;
                }
            }
            

            foreach (char ch in input)
            {
                if(Not_VowelLower.Contains(ch))
                {
                    Not_Vowel_Count++;
                    Lower_count++;
                    exist = true;
                }
            }
           

            foreach (char ch in input)
            {
                if(Sentence_Ends.Contains(ch))
                {
                    Sentence_Count++;
                    exist = true;
                }
            }
            
            foreach (char ch in input)
            {
                if(Space_Between_Words.Contains(ch))
                {
                    space_words++;
                    exist = true;
                }

            }

            Total_Letters = Lower_count + Upper_Count;



            for (int i = 0; i < 7; i++)
            {
                values.Add(0);
            }

            values[0] = Lower_count;
            values[1] = Upper_Count;
            values[2] = Is_Vowel_Count;
            values[3] = Not_Vowel_Count;
            values[4] = Sentence_Count;
            values[5] = Total_Letters;
            values[6] = space_words;
            return values;


        }
        
    }
}

