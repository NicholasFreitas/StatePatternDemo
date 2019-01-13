using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class Key
    {
        public bool _keyFits = false;

        public bool KeyFits()
        {
            return true;
        }

        public bool KeyDoesntFit()
        {
            return false;
        }

    }
}
