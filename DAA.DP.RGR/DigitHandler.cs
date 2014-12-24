using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.RGR
{
    class DigitHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request, List<char> correctDigits,  StringBuilder str)
        {
            
            if (correctDigits.Contains(request.KeyChar))
            {
                str.Append(request.KeyChar);
                Console.Write(str[str.Length - 1]);

            }
            else
            {
                if (Successor != null)
                {
                    Successor.HandleRequest(request, str);
                }
            }
        }


        public override void HandleRequest(ConsoleKeyInfo request)
        {
            throw new NotImplementedException();
        }

        public override void HandleRequest(ConsoleKeyInfo requst, StringBuilder str)
        {
            throw new NotImplementedException();
        }
    }
}
