using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{

    class Program
    {

        static void Main(string[] args)
        {

            var key = new Key();


            //====================
            var varLock = new Lock();

            varLock.OpenLock();


            varLock.UseKey(key.KeyDoesntFit());

            varLock.OpenLock();


            //===================
            varLock.UseKey(key.KeyFits());

            varLock.OpenLock();
            
            

        }
    }
}
