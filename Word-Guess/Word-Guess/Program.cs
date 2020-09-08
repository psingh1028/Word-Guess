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
    }
}