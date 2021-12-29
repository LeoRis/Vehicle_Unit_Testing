using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Plane airbus = new Plane();

            //airbus.Speed(2, 3);

            var fb = new FizzBuzz();

            var result = fb.GetOutput(15);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
