using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_StringEndsWith : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_StringEndsWith(PrettyPrint pp, string s, int n, char[] chars) : base(pp, s, n, chars)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_LastString(_s, _n, _charsAsString);
        }
    }
}
