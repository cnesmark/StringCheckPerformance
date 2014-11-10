using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_FirstCharacter : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_FirstCharacter(PrettyPrint pp, string haystack, int repetitions, char needle) : base(pp, haystack, repetitions, needle)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_FirstChar(_haystack, _repetitions, _needleChar);
        }

        public bool FC_StringIndex0()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack[0] == _needleChar) { }
            }
            return _haystack[0] == _needleChar;
        }

        public bool FC_StringIndex0Equals()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack[0].Equals(_needleChar)) { }
            }
            return _haystack[0].Equals(_needleChar);
        }

        public bool FC_LinqFirst()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack.First() == _needleChar) { }
            }
            return _haystack.First() == _needleChar;
        }

        public bool FC_StringStartsWith()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack.StartsWith(_needleCharAsString)) { }
            }
            return _haystack.StartsWith(_needleCharAsString);
        }

        public bool FC_StringIndexOf()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack.IndexOf(_needleChar) == 0) { }
            }
            return _haystack.IndexOf(_needleChar) == 0;
        }
    }
}
