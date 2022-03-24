using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManagerPiratia.Cunstruct
{
    class ReadFile
    {
        public static string[] ReadTxtFile(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            return lines;
        }
    }
}
