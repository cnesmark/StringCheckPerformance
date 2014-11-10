using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_StringStartsWith : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_StringStartsWith(PrettyPrint pp, string haystack, int iterations, char[] needle) : base(pp, haystack, iterations, needle)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_FirstString(_haystack, _needleCharsAsString);
        }

        public bool SSW_CharArray()
        {
            for (var i = 0; i < _iterations; i++)
            {
                if (_haystack.Length > _needleChars.Length)
                {
                    for (var j = 0; j < _needleChars.Length; j++)
                    {
                        if (_haystack[j] == _needleChars[j]) { }
                    }
                }
            }

            var equals = false;
            for (var j = 0; j < _needleChars.Length; j++)
            {
                if (_haystack[j] == _needleChars[j])
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


        public bool SSW_StringStartsWith()
        {
            for (var i = 0; i < _iterations; i++)
            {
                if (_haystack.StartsWith(_needleCharsAsString)) { }
            }
            return _haystack.StartsWith(_needleCharsAsString);
        }


        public bool SSW_StringIndexOf()
        {
            for (var i = 0; i < _iterations; i++)
            {
                if (_haystack.IndexOf(_needleCharsAsString) == 0) { }
            }
            return _haystack.IndexOf(_needleCharsAsString) == 0;
        }

    }
}
