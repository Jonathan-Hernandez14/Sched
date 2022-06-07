using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Data
{
    public sealed class DataBase
    {
        private static DataBase instance = null;
        private static readonly object padlock = new object();
        public BindingSource peopleDataBase;

        DataBase()
        {
            peopleDataBase = new BindingSource();
        }

        public static DataBase Instance
        {
            get
            {
                lock(padlock)
                {
                    if(instance == null)
                    {
                        instance = new DataBase();
                    }
                    return instance;
                }
            }
        }
    }
}
