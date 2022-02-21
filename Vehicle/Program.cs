using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Mocking;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Data;
using Dapper;

namespace Vehicle
{
    public interface IReadFromBase
    {
        void Read();
        void Write();
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Plane s = new Plane();
            //Type t = s.GetType();
            //t.GetProperties();
            //Console.WriteLine();
            //Console.WriteLine(t.FullName);
            //Console.ReadLine();

            ResourceManager rm = new ResourceManager("Vehicle.Song", Assembly.GetExecutingAssembly());
            Console.OutputEncoding = Encoding.UTF8;
            
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            string strSql = "SELECT DISTINCT Type AS [Key],Sound AS [Value] FROM dbo.Type_Sound_Of_Animal";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("OldM")))
            {
                myDictionary = connection.Query<KeyValuePair<string, string>>(strSql).ToDictionary(pair => pair.Key, pair => pair.Value);

                var result = myDictionary;
            }

            foreach (KeyValuePair<string, string> kvp in myDictionary)
            {
                var mkRM = rm.GetString("Macedonian").Replace("{0}", kvp.Key).Replace("{1}", kvp.Value);
                Console.WriteLine(mkRM);
                Console.WriteLine();
            }

            //var type = "cow";
            //var sound = "moo";

            //var enRM = rm.GetString("English").Replace("{0}", type).Replace("{1}", sound);
            //var mkRM = rm.GetString("Macedonian").Replace("{0}", "крава").Replace("{1}", "муу");
            //var deRM = rm.GetString("German").Replace("{0}", type).Replace("{1}", sound);

            //Console.WriteLine(enRM);
            //Console.WriteLine();
            //Console.WriteLine(mkRM);
            //Console.WriteLine();
            //Console.WriteLine(deRM);
            Console.ReadLine();
        }
    }
}
