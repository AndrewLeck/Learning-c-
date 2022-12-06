using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary >
        /// This is a main sample application
        /// </summary>
        /// <param name ='args'> an array of string arguments from the command line </param>
        /// <returns>
        /// no return value
        /// </returns>
        static void Main(string[] args)
        {
            // sing ling comments tart with two slashes
            // you can have as many of these as you want
            Console.WriteLine("Hello World!");
            /* Multiple line comments start with a slash and a star and con contunue for several
            lines undtil a closing start and a slash are
            encountered */

        }
    }
}
