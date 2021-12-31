using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vehicle.Mocking
{
    public class FileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

    }
}
