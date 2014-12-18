using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAA.DP.RGR
{
    class BackspaceHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (request.Key == ConsoleKey.Backspace)
            {
                if (request.Re)
                {
                    
                }
            }
        }


        public override void HandleRequest(ConsoleKeyInfo request, List<char> list)
        {
            throw new NotImplementedException();
        }
    }
}
