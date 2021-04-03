using System;
using System.Threading;

namespace Patterns.Creational.Singleton
{
    public class SingletonLock
    {
        private static SingletonLock _instance = null;
        private static object syncRoot = new Object();
        public static SingletonLock Instance
        {
            get
            {
              Thread.Sleep(500);
              
              if(_instance==null)

                  lock (syncRoot)
                  {
                      _instance = new SingletonLock();
                  }
                  
              return _instance;
            }
        }
    }
}