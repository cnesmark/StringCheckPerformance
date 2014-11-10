using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_LastCharacter : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_LastCharacter(PrettyPrint pp, string haystack, int repetitions, char needle) : base(pp, haystack, repetitions, needle)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_LastChar(_haystack, _repetitions, _needleChar);
        }

        public bool LC_StringIndexLength()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack[_haystack.Length - 1] == _needleChar) { }
            }
            return _haystack[_haystack.Length - 1] == _needleChar;
        }

        public bool LC_StringIndexLengthEquals()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack[_haystack.Length - 1].Equals(_needleChar)) { }
            }
            return _haystack[_haystack.Length - 1].Equals(_needleChar);
        }

        public bool LC_LinqLast()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack.Last() == _needleChar) { }
            }
            return _haystack.Last() == _needleChar;
        }

        public bool LC_StringEndsWith()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack.EndsWith(_needleCharAsString)) { }
            }
            return _haystack.EndsWith(_needleCharAsString);
        }

        public bool LC_StringIndexOf()
        {
            for (var i = 0; i < _repetitions; i++)
            {
                if (_haystack.IndexOf(_needleChar) == _haystack.Length - 1) { }
            }
            return _haystack.IndexOf(_needleChar) == _haystack.Length - 1;
        }
    }
}
