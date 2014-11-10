using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class PrettyPrint
    {
        public void Intro_TestRunner(int iterations)
        {
            Console.WriteLine("Iterations: " + iterations.ToString("### ### ### ###"));
        }

        public void Intro_FirstChar(string stringToCheck, char character)
        {
            IntroChar(stringToCheck, character, "start with");
        }

        public void Intro_LastChar(string stringToCheck, char character)
        {
            IntroChar(stringToCheck, character, "end with");
        }

        public void Intro_FirstString(string stringToCheck, string s)
        {
            IntroString(stringToCheck, s, "start with");
        }

        public void Intro_LastString(string stringToCheck, string s)
        {
            IntroString(stringToCheck, s, "end with");
        }


        public void IntroChar(string stringToCheck, char character, string location)
        {
            var message = "Does string \"{0}\" {1} character '{2}'?";
            Intro(message, stringToCheck, location, character.ToString(CultureInfo.InvariantCulture));
        }

        public void IntroString(string stringToCheck, string s, string location)
        {
            var message = "Does string \"{0}\" {1} string \"{2}\"?";
            Intro(message, stringToCheck, location, s);
        }

        public void Intro(string message, string stringToCheck, string s, string characterPosition)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(message, stringToCheck, s, characterPosition);

            Console.ForegroundColor = ConsoleColor.Gray;
        }


        public void Heading(string heading)
        {
            Console.Write((heading).PadRight(30));
        }

        public void Statement(string statement)
        {
            Console.Write(statement.PadRight(30));
        }

        public void Result(long result, bool found)
        {
            Console.WriteLine(found.ToString().ToUpper().PadRight(8) + result.ToString().PadLeft(5) + " ms");
        }

        public void Error(string error)
        {
            Console.WriteLine("ERROR: " + error);
        }
    }
}
