using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Scheduler.Common
{
    [Serializable]
    public class Person
    {
        // Person associated info
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("IsMale")]
        public bool IsMale { get; set; }

        [JsonProperty("IsAduult")]
        public bool IsAdult { get; set; }

        // availability
        [JsonProperty("SaturdayMorning")]
        public bool SaturdayMorning { get; set; }

        [JsonProperty("SaturdayAfternoon")]
        public bool SaturdayAfternoon { get; set; }

        [JsonProperty("SaturdayEvening")]
        public bool SaturdayEvening { get; set; }

        [JsonProperty("SundayMorning")]
        public bool SundayMorning { get; set; }

        [JsonProperty("SundayAfternoon")]
        public bool SundayAfternoon { get; set; }

        [JsonProperty("SundayEvening")]
        public bool SundayEvening { get; set; }

        //testing purposes constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [Newtonsoft.Json.JsonConstructor]
        public Person (
              string firstName
            , string lastName
            , bool isMale
            , bool isAdult
            , bool satMorning
            , bool satAfternoon
            , bool satEvening
            , bool sunMorning
            , bool sunAfternoon
            , bool sunEvening
            )
        {
            FirstName = firstName;
            LastName = lastName;
            IsMale = isMale;
            IsAdult = isAdult;

            SaturdayMorning = satMorning;
            SaturdayAfternoon = satAfternoon;
            SaturdayEvening = satEvening;
            SundayMorning = sunMorning;
            SundayAfternoon = sunAfternoon;
            SundayEvening = sunEvening;
        }
    }
}
