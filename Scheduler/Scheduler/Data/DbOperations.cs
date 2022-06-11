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

        private static void peopleDataBase_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }
        
    }
}
