using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.RGR
{
    class Input
    {
        internal static int Int32(string msg)
        {
            Console.Write(msg);
            ConsoleKeyInfo KeyInfo;
            List<char> CorrectDigits = new List<char> {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-'};
            while (true)
            {
                KeyInfo = Console.ReadKey(true);

            }
        }
    }
}
