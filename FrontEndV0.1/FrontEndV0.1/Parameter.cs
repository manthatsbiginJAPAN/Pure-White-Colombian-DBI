using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontEndV0._1
{

    class Parameter
    {
        private Kind _kind;
        private string _value;

        public Parameter(string value, Kind kind)
        {
            _value = value;
            _kind = kind;
        }

        public Kind Kind
        {
            get { return _kind; }
        }

        public string Value
        {
            get { return _value; }
        }
    }
}
