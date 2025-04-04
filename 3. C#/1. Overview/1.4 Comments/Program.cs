using System;

// Looks like you need to use this structure for XML comments, didn't work with the new console template
namespace MyApp
{
    internal class Program
    {
        // Single-line comment

        /* Multi-line comment
           Another line of comment
        */

        /// XML Comments
        /// <summary>
        /// This is a summary of the class
        /// </summary>
        /// <param name="args"> An array of string arguments from CLI</param>
        /// <returns> Returns nothing</returns>

        static void Main(string[] args)
        {

        }
    }
}