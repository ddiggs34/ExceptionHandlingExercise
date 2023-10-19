using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr

            char[] arr = { '1', '2', '3', '4', '5', '6', 'A', 'B', 'C' };
            // Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();
            // Create an string variable with an empty string initializer - name it str
            string str = "";

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            foreach (var character in arr)
            {
                try // create a **TRY CATCH**
                {
                    str = character.ToString(); // ToString converts and returns the string value of that instance (object/character) attempts to convert STR string 
                    int numberParsed; // new integer (numberParsed) is declared
                    if (int.TryParse(str, out numberParsed)) // if it can be Parsed into an integer, it will and come out as numberParsed
                    {
                        numbers.Add(numberParsed); //will add Parsed number to list || ListName.ADD(variable name);
                    }
                    else // if it cant Parse, it will run this
                    {
                        Console.WriteLine($"Unable to Parse '{character}'");  //output line for when cant Parse
                    }
                }
                catch (Exception e) //declares "e" as Exception variable (can rename but best practice is just to use "e" or "ex")
                {
                    Console.WriteLine($"Error: {e}");
                }

                foreach (var num in numbers)
                {
                    Console.WriteLine(num); //prints list (numbers)
                }


            }
        }
        // and Exceptions will be thrown 
        // Below we will set this up 
        // ------------------------------------------------------------------------------



        //TODO START HERE:

        // Make a foreach loop to iterate through your character array

        // Now create a try catch


        // Inside your try block
        // set your string variable to each array element in your char[] to .ToString()
        // Now, using int.Parse, parse your string variable and store in an int variable
        // Then add each int to your list

        // catch your Exception:
        // in the scope of your catch you can use the following, 

        //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

    }
}

