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
        public StringCheckPerformanceTester_LastCharacter(PrettyPrint pp, string s, int n, char c) : base(pp, s, n, c)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_LastChar(_s, _n, _c);
        }

        public bool LC_StringIndexLength()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s[_s.Length - 1] == _c) { }
            }
            return _s[_s.Length - 1] == _c;
        }

        public bool LC_StringIndexLengthEquals()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s[_s.Length - 1].Equals(_c)) { }
            }
            return _s[_s.Length - 1].Equals(_c);
        }

        public bool LC_LinqLast()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.Last() == _c) { }
            }
            return _s.Last() == _c;
        }

        public bool LC_StringEndsWith()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.EndsWith(_cAsString)) { }
            }
            return _s.EndsWith(_cAsString);
        }

        public bool LC_StringIndexOf()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.IndexOf(_c) == _s.Length - 1) { }
            }
            return _s.IndexOf(_c) == _s.Length - 1;
        }
    }
}
