﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1__Input_Processing_and_Output.Mad_Lib
{

    internal class MadLib
    {
        internal string noun, verb, adjective, adverb;
        internal MadLib() 
        {
            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            adverb = Console.ReadLine();
        }

        // Create a simple mad-lib program that prompts for a noun,
        // a verb, an adverb, and an adjective
        // and injects those into a story that you create.
        static void Main()
        {
            MadLib madlib = new MadLib();

            /*
             • Use a single output statement for this program.
             • If your language supports string interpolation or string
               substitution, use it to build up the output.
            */
            Console.WriteLine($"Do you {madlib.verb} your {madlib.adjective} {madlib.noun} {madlib.adverb}? That's hilarious!");
        }
    }
}
