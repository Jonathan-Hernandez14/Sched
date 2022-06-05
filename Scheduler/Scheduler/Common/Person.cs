using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Common
{
    public class Person
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsMale { get; set; }
        public bool IsAdult { get; set; }

        //testing purposes constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
