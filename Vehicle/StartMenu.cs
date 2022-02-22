using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class StartMenu
    {
        public void CreateMenu()
        {
            Console.WriteLine("Which version would you like to see?\n1.Macedonian\n2.English");

            do
            {
                string versionSelector = Console.ReadLine();

                if (versionSelector == "1")
                {
                    PresentSong.PresentFullSong();
                    break;
                }
                else if (versionSelector == "2")
                {
                    PresentSong.PresentWholeSong();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input - try again.");

                }
            }
            while (true);

        }
    }
}
