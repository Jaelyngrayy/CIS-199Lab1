// Grading ID: R5560
// Lab 1
// Due Date: January 24, 2021
// Course Section: CIS 199-01

/* Program Description: Displays my Grading ID, hobbies, favorite book and movie to the console. 
 With each one being on a seperate, new line. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab1
{
    // Run by going to Debug and then Start without Debugging
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Grading ID:     R5560");
            WriteLine("Hobbies:        Playing video games, watching anime, and bowling");
            WriteLine("Favorite Book:  My favorite book, including manga, is Attack On Titan");
            WriteLine("Favorite Movie: Spider-Man: Into the Spider-Verse");
            
            // No need for "System.Console." before WriteLine since I added:
            // "usage static System.Console" above.
        }
    }
}
