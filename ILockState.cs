using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    interface ILockState
    {
        void UseKey(bool keyFits);
        void OpenLock();
    }
}
