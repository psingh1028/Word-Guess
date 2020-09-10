using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Word Guess app!");

            var phrases = getPhrase();

            // this code is a test to print out something from the list. 

            //for(int i=0; i<phrases.Count;i++)
            //{
            //    Console.WriteLine(phrases[i]);
            //}

            Console.WriteLine(SelectPhrase(phrases));


            Console.ReadKey();
        }

        public static List<String> getPhrase()
        {
            var phrases = new List<String>();

            phrases.Add("Durant");
            phrases.Add("James");
            phrases.Add("Harden");
            phrases.Add("Curry");
            phrases.Add("Irving");
            phrases.Add("Davis");

            return phrases;
        }


        public static String SelectPhrase(List<String> Phrases) // this method will be used to randomly select a phrase for the user to guess. 
        {
            var random = new Random(); // creates an object of class Random called "random"
            var randomNumber = random.Next(0, 5); // sets variable "randomNumber" to a number selected by the random.Next method in class Random


            return Phrases[randomNumber];
        }
    }
}