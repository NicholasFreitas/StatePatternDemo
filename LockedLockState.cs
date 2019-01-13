using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class LockedLockState : ILockState
    {
        Lock _lock;
        bool _keyFits = false;

        public LockedLockState(Lock ctor_lock)
        {
            _lock = ctor_lock;
        }

        public void OpenLock()
        {
            if (_keyFits)
            {
                Console.WriteLine("Click!");
                this._lock.ChangeLockState(new UnlockedLockState(this._lock));
            }
            else
            {
                Console.WriteLine("The Lock does not open.");
            }           

        }

        public void UseKey(bool keyFits)
        {
            _keyFits = keyFits;
        }
    }
}
