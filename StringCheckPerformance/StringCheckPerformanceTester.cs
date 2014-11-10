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
        protected string _haystack;
        protected int _iterations;
        protected char _needleChar;
        protected string _needleCharAsString;
        protected char[] _needleChars;
        protected string _needleCharsAsString;

        public StringCheckPerformanceTester(PrettyPrint pp, string haystack, int iterations, char needle)
        {
            _pp = pp;
            _haystack = haystack;
            _iterations = iterations;
            _needleChar = needle;
            _needleCharAsString = needle.ToString(CultureInfo.CurrentCulture);
        }

        public StringCheckPerformanceTester(PrettyPrint pp, string haystack, int iterations, char[] needle)
        {
            _pp = pp;
            _haystack = haystack;
            _iterations = iterations;
            _needleChars = needle;
            _needleCharsAsString = new string(_needleChars);
        }

        public delegate bool StringCheckPerformanceTest();

        public void Run(StringCheckPerformanceTest stringCheckPerformanceTest)
        {
            _pp.Heading(stringCheckPerformanceTest.GetMethodInfo().Name);
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var testToRun = stringCheckPerformanceTest();
            stopWatch.Stop();
            _pp.Result(stopWatch.ElapsedMilliseconds, testToRun);
        }

        public abstract void Intro();

    }
}
