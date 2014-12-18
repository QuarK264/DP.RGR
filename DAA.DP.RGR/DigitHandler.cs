using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.RGR
{
    class DigitHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request, List<char> correctDigits)
        {
            StringBuilder str = new StringBuilder();
            if (correctDigits.Contains(request.KeyChar))
            {
                str.Append(request.KeyChar);
                //Input.ClearConsoleLine();
                Console.Write(str.ToString());
            }
            else
            {
                if (Successor != null)
                {
                    Successor.HandleRequest(request);
                }
            }
        }

        public override void HandleRequest(ConsoleKeyInfo request)
        {
            throw new NotImplementedException();
        }
    }
}
