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
    abstract class StringCheckPerformanceTester
    {
        protected PrettyPrint _pp;
        protected string _s;
        protected int _n;
        protected char _c;
        protected string _cAsString;
        protected char[] _chars;
        protected string _charsAsString;

        public StringCheckPerformanceTester(PrettyPrint pp, string s, int n, char c)
        {
            _pp = pp;
            _s = s;
            _n = n;
            _c = c;
            _cAsString = c.ToString(CultureInfo.CurrentCulture);
        }

        public StringCheckPerformanceTester(PrettyPrint pp, string s, int n, char[] chars)
        {
            _pp = pp;
            _s = s;
            _n = n;
            _chars = chars;
            _charsAsString = new string(_chars);
        }

        public delegate bool StringCheckPerformanceTest();

        public void Run(StringCheckPerformanceTest d)
        {
            _pp.Heading(d.GetMethodInfo().Name);
            var sw = new Stopwatch();
            sw.Start();
            var r = d();
            sw.Stop();
            _pp.Result(sw.ElapsedMilliseconds, r);
        }

        public abstract void Intro();

    }
}
