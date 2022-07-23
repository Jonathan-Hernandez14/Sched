using Newtonsoft.Json;
using Scheduler.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Data
{
    public class DbOperations
    {
        /// <summary>
        /// Upon startup, look for DB text document and load information from that document.
        /// Otherwise just create the text file at specified location.
        /// </summary>
        public static void GenOrRead()
        {
            string line;

            DataBase.Instance.peopleDataBase.BindingComplete += new BindingCompleteEventHandler(peopleDataBase_BindingComplete);

            //check to see if the data file exists.
            if (File.Exists(Global.masterDBPath))
            {
                try
                {
                    StreamReader sr = new StreamReader(Global.masterDBPath);
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        //make json object
                        Person readPerson = JsonConvert.DeserializeObject<Person>(line);
                        //add to masterlist
                        //*Crud.addToMasterList(line);
                        //add to DB binding source
                        DataBase.Instance.peopleDataBase.Add(readPerson);
                        //move to next object
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

            }
            else
            {
                //create file and close
                try
                {
                    StreamWriter sw = new StreamWriter(Global.masterDBPath);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        public static void GenerateCombos()
        {
            throw new NotImplementedException();
        }

        /*
       public static void SortDbPeopleByDay()
       {
           foreach(Person person in DataBase.Instance.peopleDataBase)
           {
               CategorizePerson(person);
           }
       }

       public static void CategorizePerson(Person person)
       {
           if (person.SaturdayMorning)
           {
               DataBase.Instance.SatMorning.Add(person);
           }
           if (person.SaturdayAfternoon)
           {
               DataBase.Instance.SatAfternoon.Add(person);
           }
           if (person.SaturdayEvening)
           {
               DataBase.Instance.SatEvening.Add(person);
           }
           if (person.SundayMorning)
           {
               DataBase.Instance.SunMorning.Add(person);
           }
           if (person.SundayAfternoon)
           {
               DataBase.Instance.SunAfternoon.Add(person);
           }
           if (person.SundayEvening)
           {
               DataBase.Instance.SunEvening.Add(person);
           }
       }
*/
        /// <summary>
        /// Adding a person to the program will add to the binding source as well as the DB text
        /// </summary>
        /// <param name="personToAdd"></param>
        public static void AddPerson(Person personToAdd)
        {
            // add to binding source
            DataBase.Instance.peopleDataBase.Add(personToAdd);

            // add to DB text file
            string json = JsonConvert.SerializeObject(personToAdd);
            File.AppendAllText(Global.masterDBPath, json + Environment.NewLine);
        }

        /// <summary>
        /// Removing a person from the Binding source
        /// </summary>
        /// <param name="personToRemove"></param>
        public static void RemovePerson(Person personToRemove)
        {
            //Remove from Binding Source
            DataBase.Instance.peopleDataBase.Remove(personToRemove);
            //Remove from elsewhere
        }

        /// <summary>
        /// Changes made to a persons info will trigger a replacement on person object in the binding source
        /// </summary>
        /// <param name="personToUpdate"></param>
        /// <param name="bindingSourceIndex"></param>
        public static void UpdatePerson(Person updatedPerson, int bindingSourceIndex)
        {
            DataBase.Instance.peopleDataBase[bindingSourceIndex] = updatedPerson;
        }

        /// <summary>
        /// Replaces the Master DB text file with the current state of the Binding source
        /// </summary>
        public static void UpdateDB()
        {
            var peopleList = DataBase.Instance.peopleDataBase.List;
            File.Create(Global.masterDBPath).Close();
            foreach (Person person in peopleList)
            {
                string json = JsonConvert.SerializeObject(person);
                File.AppendAllText(Global.masterDBPath, json + Environment.NewLine);
            }
        }

        

        private static void peopleDataBase_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }
        
    }
}
