using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToBaseString
{
    class Program
    {
        // Array of single character strings.
        // Use base 10 integer as an index, get the corresponding character representing that number
        // in the selected base, up to base 36.
        static string[] sChar = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                 "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                                 "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};


        static void Main(string[] args)
        {
            // Creates a string that represents an input non-negative base-10 integer in another
            // base, which is specified by the user.
            // For example, if the input integer is 4 and the base is 2, then the string that is 
            // created would be "100".

            // Get the number from the user.
            int n = ConsoleIO.getNumber();

            // Get the base.  Must be no less than 2 and no greater than 36.
            int b = ConsoleIO.getNumber(2, 36);


            // Create the string representing the integer n, in base b.
            string s = convertIntToBaseString(n, b);


            // Display the result on the console.
            ConsoleIO.showResult(n, b, s);

            ConsoleIO.waitForKeypress();
        }


        static string convertIntToBaseString(int n, int b)
        {
            // Converts the input integer n to a string,
            // representing its value in base b.
            // For example, if n = 3 and b = 2, this function returns "11".

            // Successive digits are calculated by calling this function recursively.


            string s = "";  // Initialize the return string.

            // First, check if n < b.  
            if (n < b)
            {
                // In this case, simply return n as a string.
                s = sChar[n];
            }
            else
            {
                // Find the remainder, when you divide n by b.
                // Example: n = 157, b = 10: remainder = 7.
                int remainder = 0;  // create the remainder variable.
                // Add code here to calculate the value of the remainder.
                // Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/modulus-operator
                //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                // <-------------------------------------------------------------------------------------- Add one line of code here
                //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^



                // Set the output to the string version of the remainder.
                // Example: remainder = 7: endOfString = "7".
                string endOfString = sChar[remainder];

                // Calculate the reduced number to (n - remainder) / b.
                // Example: n = 157, b = 10, remainder = 7: reducedNumber = (157 - 7) / 10 = 15.
                int reducedNumber = (n - remainder) / b;



                // Get the string representation of this reduced number.
                // Example: reducedNumber = 15, b = 10: startOfString = "15".
                // Note: startOfString is obtained by calling this function, convertIntToBaseString, recursively.
                string startOfString = ""; // Create the startOfString variable.
                // Add code here to obtain startOfString by calling this function recursively.
                // Reference: Quick Calculation #2: Factorial by Recursion.
                //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                // <-------------------------------------------------------------------------------------- Add one line of code here
                //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^



                // Append the rest of the string and the remainder string as the output.
                // Example: startOfString = "15", endOfString = "7": s = "157"
                s = startOfString + endOfString;
            }

            return s;
        }

    }
}
