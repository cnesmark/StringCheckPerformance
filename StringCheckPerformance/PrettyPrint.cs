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
        public void Intro_FirstChar(string stringToCheck, int repetitions, char character)
        {
            IntroChar(stringToCheck, character, "starts with", repetitions);
        }

        public void Intro_LastChar(string stringToCheck, int repetitions, char character)
        {
            IntroChar(stringToCheck, character, "ends with", repetitions);
        }

        public void Intro_FirstString(string stringToCheck, int repetitions, string s)
        {
            IntroString(stringToCheck, s, "starts with", repetitions);
        }

        public void Intro_LastString(string stringToCheck, int repetitions, string s)
        {
            IntroString(stringToCheck, s, "ends with", repetitions);
        }


        public void IntroChar(string stringToCheck, char character, string location, int repetitions)
        {
            var message = "Check if string \"{0}\" {1} the character '{2}'.";
            Intro(message, stringToCheck, location, character.ToString(CultureInfo.InvariantCulture), repetitions);
        }

        public void IntroString(string stringToCheck, string s, string location, int repetitions)
        {
            var message = "Check if string \"{0}\" {1} the string \"{2}\".";
            Intro(message, stringToCheck, location, s, repetitions);
        }

        public void Intro(string message, string stringToCheck, string s, string characterPosition, int repetitions)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(message, stringToCheck, s, characterPosition);
            Console.WriteLine("Repetitions: " + repetitions.ToString("### ### ### ###"));

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }


        public void Heading(string heading)
        {
            Console.Write((heading).PadRight(40));
        }

        public void Statement(string statement)
        {
            Console.Write(statement.PadRight(30));
        }

        public void Result(long result, bool found)
        {
            Console.WriteLine(found.ToString().ToUpper().PadRight(10) + "  " + result + " ms");
        }

        public void Error(string error)
        {
            Console.WriteLine("ERROR: " + error);
        }
    }
}
