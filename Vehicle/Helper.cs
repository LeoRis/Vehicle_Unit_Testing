using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public static class Helper
    {
        public static string CnnValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        internal static string ConnectionValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}
