using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTestRunner
    {
        private PrettyPrint _pp;
        private int _iterations;

        public StringCheckPerformanceTestRunner(PrettyPrint pp, int iterations)
        {
            _pp = pp;
            _iterations = iterations;
        }

        public void Scpt_FirstCharacter_asdf_a()
        {
            var haystack = "asdf";
            var needle = 'a';

            var scpt = new StringCheckPerformanceTester_FirstCharacter(_pp, haystack, _iterations, needle);

            scpt.Intro();
            scpt.Run(scpt.FC_StringIndex0);
            scpt.Run(scpt.FC_StringIndex0Equals);
            scpt.Run(scpt.FC_LinqFirst);
            scpt.Run(scpt.FC_StringStartsWith);
            scpt.Run(scpt.FC_StringIndexOf);
        }

        public void Scpt_FirstCharacter_asdf_f()
        {
            var haystack = "asdf";
            var needle = 'f';

            var scpt = new StringCheckPerformanceTester_FirstCharacter(_pp, haystack, _iterations, needle);

            scpt.Intro();
            scpt.Run(scpt.FC_StringIndex0);
            scpt.Run(scpt.FC_StringIndex0Equals);
            scpt.Run(scpt.FC_LinqFirst);
            scpt.Run(scpt.FC_StringStartsWith);
            scpt.Run(scpt.FC_StringIndexOf);
        }

        public void Scpt_LastCharacter_asdf_a()
        {
            var haystack = "asdf";
            var needle = 'a';

            var scpt = new StringCheckPerformanceTester_LastCharacter(_pp, haystack, _iterations, needle);

            scpt.Intro();
            scpt.Run(scpt.LC_StringIndexLength);
            scpt.Run(scpt.LC_StringIndexLengthEquals);
            scpt.Run(scpt.LC_LinqLast);
            scpt.Run(scpt.LC_StringEndsWith);
            scpt.Run(scpt.LC_StringIndexOf);
        }

        public void Scpt_LastCharacter_asdf_f()
        {
            var haystack = "asdf";
            var needle = 'f';

            var scpt = new StringCheckPerformanceTester_LastCharacter(_pp, haystack, _iterations, needle);

            scpt.Intro();
            scpt.Run(scpt.LC_StringIndexLength);
            scpt.Run(scpt.LC_StringIndexLengthEquals);
            scpt.Run(scpt.LC_LinqLast);
            scpt.Run(scpt.LC_StringEndsWith);
            scpt.Run(scpt.LC_StringIndexOf);
        }

        public void Scpt_FirstCharacter_jklø_ø()
        {
            var haystack = "jklø";
            var needle = 'ø';

            var scpt = new StringCheckPerformanceTester_FirstCharacter(_pp, haystack, _iterations, needle);

            scpt.Intro();
            scpt.Run(scpt.FC_StringIndex0);
            scpt.Run(scpt.FC_StringIndex0Equals);
            scpt.Run(scpt.FC_LinqFirst);
            scpt.Run(scpt.FC_StringStartsWith);
            scpt.Run(scpt.FC_StringIndexOf);
        }

        public void Scpt_LastCharacter_jklø_ø()
        {
            var haystack = "jklø";
            var needle = 'ø';

            var scpt = new StringCheckPerformanceTester_LastCharacter(_pp, haystack, _iterations, needle);

            scpt.Intro();
            scpt.Run(scpt.LC_StringIndexLength);
            scpt.Run(scpt.LC_StringIndexLengthEquals);
            scpt.Run(scpt.LC_LinqLast);
            scpt.Run(scpt.LC_StringEndsWith);
            scpt.Run(scpt.LC_StringIndexOf);
        }


        public void Scpt_StringStartsWith_asdf_asd()
        {
            var haystack = "asdf";
            var needleChars = "asd".ToCharArray();

            var scpt = new StringCheckPerformanceTester_StringStartsWith(_pp, haystack, _iterations, needleChars);

            scpt.Intro();
            scpt.Run(scpt.SSW_CharArray);
            scpt.Run(scpt.SSW_StringStartsWith);
            scpt.Run(scpt.SSW_StringIndexOf);
        }

        public void Scpt_StringStartsWith_asdf_abc()
        {
            var haystack = "asdf";
            var needleChars = "abc".ToCharArray();

            var scpt = new StringCheckPerformanceTester_StringStartsWith(_pp, haystack, _iterations, needleChars);

            scpt.Intro();
            scpt.Run(scpt.SSW_CharArray);
            scpt.Run(scpt.SSW_StringStartsWith);
            scpt.Run(scpt.SSW_StringIndexOf);
        }

        public void Scpt_StringEndsWith_asdf_sdf()
        {
            var haystack = "asdf";
            var needleChars = "sdf".ToCharArray();

            var scpt = new StringCheckPerformanceTester_StringEndsWith(_pp, haystack, _iterations, needleChars);

            scpt.Intro();

            scpt.Run(scpt.SEW_CharArray);
            scpt.Run(scpt.SEW_StringEndsWith);
            scpt.Run(scpt.SEW_StringIndexOf);
        }

        public void Scpt_StringEndsWith_asdf_cba()
        {
            var haystack = "asdf";
            var needleChars = "cba".ToCharArray();

            var scpt = new StringCheckPerformanceTester_StringEndsWith(_pp, haystack, _iterations, needleChars);

            scpt.Intro();

            scpt.Run(scpt.SEW_CharArray);
            scpt.Run(scpt.SEW_StringEndsWith);
            scpt.Run(scpt.SEW_StringIndexOf);
        }

    }
}
