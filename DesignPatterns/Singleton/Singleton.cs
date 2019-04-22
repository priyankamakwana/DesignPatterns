using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton singleton;

        //public static Singleton GetInstance()
        //{
        //    if (singleton == null)
        //        singleton = new Singleton();
        //    return singleton;
        //}

        public static Singleton Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new Singleton();
                return singleton;
            }
        }
    }
}
