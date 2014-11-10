using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_StringStartsWith : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_StringStartsWith(PrettyPrint pp, string s, int n, char[] chars) : base(pp, s, n, chars)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_FirstString(_s, _n, _charsAsString);
        }

        public bool SSW_CharArray()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.Length > _chars.Length)
                {
                    for (var j = 0; j < _chars.Length; j++)
                    {
                        if (_s[j] == _chars[j]) { }
                    }
                }
            }

            var equals = false;
            for (var j = 0; j < _chars.Length; j++)
            {
                if (_s[j] == _chars[j])
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
            for (var i = 0; i < _n; i++)
            {
                if (_s.StartsWith(_charsAsString)) { }
            }
            return _s.StartsWith(_charsAsString);
        }


        public bool SSW_StringIndexOf()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.IndexOf(_charsAsString) == 0) { }
            }
            return _s.IndexOf(_charsAsString) == 0;
        }

    }
}
