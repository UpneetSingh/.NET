using System;
using AnagramProgram.Models;

namespace AnagramProgram
{
    public class Program
    {
            public static void Main()
            {
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("Hi User! Welcome to Anagram Detector!");
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("You'll input two different words that may or may not be Anagrams!");
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("Our Detector will detect if the words are Anagram or not! Let's do it!");
                System.Console.WriteLine("-------------------------------------");

                System.Console.WriteLine("Please enter first word");
                string userInput1 = Console.ReadLine();
                System.Console.WriteLine("Please enter second word");
                string userInput2 = Console.ReadLine();

                if(userInput1 == userInput2)
                {
                    System.Console.WriteLine("Cannot input same words,duh...");
                    System.Console.WriteLine("Exiting Program...");
                }

                else
                {
                    string word1 = userInput1.ToLower();
                    string word2 = userInput2.ToLower();

                    Anagram agm = new Anagram(word1,word2);

                    ConfirmAndCheckAnagram(agm);

                    static void ConfirmAndCheckAnagram(Anagram agm)
                    {

                        char[] arr1 = agm.Word1.ToCharArray();
                        char[] arr2 = agm.Word2.ToCharArray();

                        Array.Sort(arr1);
                        Array.Sort(arr2);

                        string newWord1 = string.Join("",arr1);
                        string newWord2 = string.Join("",arr2);

                        if(newWord1 == newWord2)
                        {
                            System.Console.WriteLine("Detector working its magic.....Anagram Detected!"); 
                        }

                        else
                        {
                            System.Console.WriteLine("Detector working its magic.....Not an Anagram!");

                        }

                }

                }
                
            }

    }



}
