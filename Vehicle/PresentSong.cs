using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class PresentSong
    {
        public static void PresentFullSong()
        {
            ResourceManager rm = new ResourceManager("Vehicle.Song", Assembly.GetExecutingAssembly());
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            string strSql = "SELECT DISTINCT Type AS [Key],Sound AS [Value] FROM dbo.Type_Sound_Of_Animal";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("OldM")))
            {
                myDictionary = connection.Query<KeyValuePair<string, string>>(strSql).ToDictionary(pair => pair.Key.Trim(), pair => pair.Value.Trim());

                var result = myDictionary;
            }

            foreach (KeyValuePair<string, string> kvp in myDictionary)
            {
                var mkRM = rm.GetString("Macedonian").Replace("{0}", kvp.Key).Replace("{1}", kvp.Value);
                Console.WriteLine(mkRM + "\n");
            }
        }

        public static void PresentWholeSong()
        {
            ResourceManager rm = new ResourceManager("Vehicle.Song", Assembly.GetExecutingAssembly());

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            string strSql = "SELECT DISTINCT Type AS [Key],Sound AS [Value] FROM dbo.Type_Sound_Of_Animal";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("OldM")))
            {
                myDictionary = connection.Query<KeyValuePair<string, string>>(strSql).ToDictionary(pair => pair.Key.Trim(), pair => pair.Value.Trim());

                var result = myDictionary;
            }

            foreach (KeyValuePair<string, string> kvp in myDictionary)
            {
                var mkRM = rm.GetString("English").Replace("{0}", kvp.Key).Replace("{1}", kvp.Value);
                Console.WriteLine(mkRM + "\n");
            }
        }
    }
}
