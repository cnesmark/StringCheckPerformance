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
        private int _n;

        public StringCheckPerformanceTestRunner(PrettyPrint pp, int n)
        {
            _pp = pp;
            _n = n;
        }

        public void Scpt_FirstCharacter_asdf_a()
        {
            var s = "asdf";
            var c = 'a';

            var scpt = new StringCheckPerformanceTester_FirstCharacter(_pp, s, _n, c);

            scpt.Intro();
            scpt.Run(scpt.FC_StringIndex0);
            scpt.Run(scpt.FC_StringIndex0Equals);
            scpt.Run(scpt.FC_LinqFirst);
            scpt.Run(scpt.FC_StringStartsWith);
            scpt.Run(scpt.FC_StringIndexOf);
        }

        public void Scpt_FirstCharacter_asdf_f()
        {
            var s = "asdf";
            var c = 'f';

            var scpt = new StringCheckPerformanceTester_FirstCharacter(_pp, s, _n, c);

            scpt.Intro();
            scpt.Run(scpt.FC_StringIndex0);
            scpt.Run(scpt.FC_StringIndex0Equals);
            scpt.Run(scpt.FC_LinqFirst);
            scpt.Run(scpt.FC_StringStartsWith);
            scpt.Run(scpt.FC_StringIndexOf);
        }

        public void Scpt_LastCharacter_asdf_a()
        {
            var s = "asdf";
            var c = 'a';

            var scpt = new StringCheckPerformanceTester_LastCharacter(_pp, s, _n, c);

            scpt.Intro();
            scpt.Run(scpt.LC_StringIndexLength);
            scpt.Run(scpt.LC_StringIndexLengthEquals);
            scpt.Run(scpt.LC_LinqLast);
            scpt.Run(scpt.LC_StringEndsWith);
            scpt.Run(scpt.LC_StringIndexOf);
        }

        public void Scpt_LastCharacter_asdf_f()
        {
            var s = "asdf";
            var c = 'f';

            var scpt = new StringCheckPerformanceTester_LastCharacter(_pp, s, _n, c);

            scpt.Intro();
            scpt.Run(scpt.LC_StringIndexLength);
            scpt.Run(scpt.LC_StringIndexLengthEquals);
            scpt.Run(scpt.LC_LinqLast);
            scpt.Run(scpt.LC_StringEndsWith);
            scpt.Run(scpt.LC_StringIndexOf);
        }

        public void Scpt_FirstCharacter_jklø_ø()
        {
            var s = "jklø";
            var c = 'ø';

            var scpt = new StringCheckPerformanceTester_FirstCharacter(_pp, s, _n, c);

            scpt.Intro();
            scpt.Run(scpt.FC_StringIndex0);
            scpt.Run(scpt.FC_StringIndex0Equals);
            scpt.Run(scpt.FC_LinqFirst);
            scpt.Run(scpt.FC_StringStartsWith);
            scpt.Run(scpt.FC_StringIndexOf);
        }

        public void Scpt_LastCharacter_jklø_ø()
        {
            var s = "jklø";
            var c = 'ø';

            var scpt = new StringCheckPerformanceTester_LastCharacter(_pp, s, _n, c);

            scpt.Intro();
            scpt.Run(scpt.LC_StringIndexLength);
            scpt.Run(scpt.LC_StringIndexLengthEquals);
            scpt.Run(scpt.LC_LinqLast);
            scpt.Run(scpt.LC_StringEndsWith);
            scpt.Run(scpt.LC_StringIndexOf);
        }


        public void Scpt_StringStartsWith_asdf_asd()
        {
            var s = "asdf";
            var chars = "asd".ToCharArray();

            var scpt = new StringCheckPerformanceTester_StringStartsWith(_pp, s, _n, chars);

            scpt.Intro();
            scpt.Run(scpt.SSW_CharArray);
            scpt.Run(scpt.SSW_StringStartsWith);
        }


    }
}
