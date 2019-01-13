using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class UnlockedLockState : ILockState
    {
        Lock _lock;
        bool _keyFits = false;
        
        public UnlockedLockState(Lock ctor_lock)
        {
            _lock = ctor_lock;
        }

        public void OpenLock()
        {
            Console.WriteLine("The lock is already open.");
            this._lock.ChangeLockState(new UnlockedLockState(this._lock));
            
        }

        public void UseKey(bool keyFits)
        {
            if(_keyFits)
                this._lock.ChangeLockState(new LockedLockState(this._lock));
        }
    }
}
