using Scheduler.Common;
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

        public List<List<Person>> SatMorningCombo = new List<List<Person>>();
        public List<Person> SatAfternoonCombo = new List<Person>();
        public List<Person> SatEveningCombo = new List<Person>();

        public List<Person> SunMorningCombo = new List<Person>();
        public List<Person> SunAfternoonCombo = new List<Person>();
        public List<Person> SunEveningCombo = new List<Person>();

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
