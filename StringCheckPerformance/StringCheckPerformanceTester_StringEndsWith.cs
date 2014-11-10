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

        public bool SEW_CharArray()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.Length > _chars.Length)
                {
                    var startIndex = _s.Length - _chars.Length;
                    for (var j = 0; j < _chars.Length; j++)
                    {
                        if (_s[j + startIndex] == _chars[j]) { }
                    }
                }
            }

            var equals = false;
            for (var j = 0; j < _chars.Length; j++)
            {
                if (_s[j + _s.Length - _chars.Length] == _chars[j])
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
            for (var i = 0; i < _n; i++)
            {
                if (_s.EndsWith(_charsAsString)) { }
            }
            return _s.EndsWith(_charsAsString);
        }


        public bool SEW_StringIndexOf()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.IndexOf(_charsAsString) == _s.Length - _charsAsString.Length) { }
            }
            return _s.IndexOf(_charsAsString) == _s.Length - _charsAsString.Length;
        }
    }
}
