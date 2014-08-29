using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10000000;
            var pp = new PrettyPrint();

            var scptr = new StringCheckPerformanceTestRunner(pp, n);
            //scptr.Scpt_FirstCharacter_asdf_a();
            //scptr.Scpt_FirstCharacter_asdf_f();

            //scptr.Scpt_LastCharacter_asdf_a();
            //scptr.Scpt_LastCharacter_asdf_f();

            scptr.Scpt_FirstCharacter_jklø_ø();
            scptr.Scpt_LastCharacter_jklø_ø();


            //scptr.Scpt_StringStartsWith_asdf_asd();

            Console.ReadLine();
        }
    }
}
