using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_StringEndsWith : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_StringEndsWith(PrettyPrint pp, string haystack, int iterations, char[] needle) : base(pp, haystack, iterations, needle)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_LastString(_haystack, _needleCharsAsString);
        }

        public bool SEW_CharArray()
        {
            for (var i = 0; i < _iterations; i++)
            {
                if (_haystack.Length > _needleChars.Length)
                {
                    var startIndex = _haystack.Length - _needleChars.Length;
                    for (var j = 0; j < _needleChars.Length; j++)
                    {
                        if (_haystack[j + startIndex] == _needleChars[j]) { }
                    }
                }
            }

            var equals = false;
            for (var j = 0; j < _needleChars.Length; j++)
            {
                if (_haystack[j + _haystack.Length - _needleChars.Length] == _needleChars[j])
                {
                    equals = true;
                }
                else
                {
                    equals = false;
                    break;
                }
            }
            return equals;
        }


        public bool SEW_StringEndsWith()
        {
            for (var i = 0; i < _iterations; i++)
            {
                if (_haystack.EndsWith(_needleCharsAsString)) { }
            }
            return _haystack.EndsWith(_needleCharsAsString);
        }


        public bool SEW_StringIndexOf()
        {
            for (var i = 0; i < _iterations; i++)
            {
                if (_haystack.IndexOf(_needleCharsAsString) == _haystack.Length - _needleCharsAsString.Length) { }
            }
            return _haystack.IndexOf(_needleCharsAsString) == _haystack.Length - _needleCharsAsString.Length;
        }
    }
}
