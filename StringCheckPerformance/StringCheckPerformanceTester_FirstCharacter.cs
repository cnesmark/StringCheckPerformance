using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckPerformance
{
    class StringCheckPerformanceTester_FirstCharacter : StringCheckPerformanceTester
    {
        public StringCheckPerformanceTester_FirstCharacter(PrettyPrint pp, string s, int n, char c) : base(pp, s, n, c)
        {
            
        }

        public override void Intro()
        {
            _pp.Intro_FirstChar(_s, _n, _c);
        }

        public bool FC_StringIndex0()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s[0] == _c) { }
            }
            return _s[0] == _c;
        }

        public bool FC_StringIndex0Equals()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s[0].Equals(_c)) { }
            }
            return _s[0].Equals(_c);
        }

        public bool FC_LinqFirst()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.First() == _c) { }
            }
            return _s.First() == _c;
        }

        public bool FC_StringStartsWith()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.StartsWith(_cAsString)) { }
            }
            return _s.StartsWith(_cAsString);
        }

        public bool FC_StringIndexOf()
        {
            for (var i = 0; i < _n; i++)
            {
                if (_s.IndexOf(_c) == 0) { }
            }
            return _s.IndexOf(_c) == 0;
        }
    }
}
