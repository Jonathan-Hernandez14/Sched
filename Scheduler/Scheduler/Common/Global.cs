using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Common
{
    public static class Global
    {
        //public static string systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        public static string systemPath = "C:\\";
        public static string masterDBPath = Path.Combine(systemPath, "files\\DB.txt");
    }
}
