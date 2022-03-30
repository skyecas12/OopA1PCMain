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
            int Total_Letters = 0;
            bool exist = false;
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'


            foreach (char ch in input)
            {
                for (int i = 0; i < Upper_Not_Vowel.Length; i++)
                {
                    if (Upper_Not_Vowel[i] == ch.ToString())
                    {
                        Upper_Count++;
                        Not_Vowel_Count++;
                        exist = true;
                        
                    }
                }
            }

            foreach (char ch in input)
            {
                for (int i = 0; i < Upper_Vowel.Length; i++)
                {
                    if (Upper_Vowel[i] == ch.ToString())
                    {
                        Upper_Count++;
                        Is_Vowel_Count++;
                        exist = true; 
                    }
                }
            }

            foreach (char ch in input)
            {
                for (int i = 0; i < Is_VowelLower.Length; i++)
                {
                    if (Is_VowelLower[i] == ch.ToString())
                    {
                        Lower_count++;
                        Is_Vowel_Count++;
                        exist = true;
                    }
                }
            }

            foreach (char ch in input)
            {
                for (int i = 0; i < Not_VowelLower.Length; i++)
                {
                    if(Not_VowelLower[i] == ch.ToString())
                    {
                        Not_Vowel_Count++;
                        Lower_count++;
                        exist = true;
                    }
                }
            }

            foreach (char ch in input)
            {
                for (int i = 0; i < Sentence_Ends.Length; i++ )
                {
                    if(Sentence_Ends[i] == ch.ToString())
                    {
                        Sentence_Count++;
                        exist = true;
                    }
                }
            }

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

