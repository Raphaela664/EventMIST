using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EventMIS
{
    internal class AppConnection
    {
        public static string getConString()
        {
            return ConfigurationManager.ConnectionStrings["eventCon"].ConnectionString;
        }
    }
}
