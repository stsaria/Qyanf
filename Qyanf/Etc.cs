using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qyanf
{
    internal class Etc
    {
        public bool InputYesNo(string text)
        {
            while (true)
            {
                Console.Write(text);
                var input = Console.ReadLine();
                Console.WriteLine("");
                if (input != null)
                {
                    if (input.ToLower().Contains("y")) {
                        return true;
                    }
                    else if (input.ToLower().Contains("n")) {
                        return false;
                    } else {
                        continue;
                    }
                }
            }
        }
    }
}
