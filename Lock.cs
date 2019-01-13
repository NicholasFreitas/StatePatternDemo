using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class Lock
    {
        ILockState CurrentLockState;

        public Lock()
        {
            CurrentLockState = new LockedLockState(this);
        }

        public void UseKey(bool keyFits)
        {
            CurrentLockState.UseKey(keyFits);
        }

        public void OpenLock()
        {
            CurrentLockState.OpenLock();
        }

        public void ChangeLockState(ILockState lockState)
        {
            CurrentLockState = lockState;
        }


    }
}
