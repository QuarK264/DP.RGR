using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAA.DP.RGR
{
    class EnterHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request, StringBuilder str)
        {
            if (request.Key == ConsoleKey.Enter && BackspaceHandler.IsNotEmpty(str))
            {
                
            }
            else
            {
                Console.Beep();
            }
        }

        public override void HandleRequest(ConsoleKeyInfo request, List<char> list, StringBuilder str)
        {
            throw new NotImplementedException();
        }

        public override void HandleRequest(ConsoleKeyInfo request)
        {
            throw new NotImplementedException();
        }
    }
}
