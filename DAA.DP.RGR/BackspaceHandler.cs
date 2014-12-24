using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAA.DP.RGR
{
    class BackspaceHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request, StringBuilder str)
        {
            if (request.Key == ConsoleKey.Backspace)
            {
                if (RemoveLastSymbol(str))
                {
                    Console.Write(str.ToString());
                }
            }
            else
            {
                if (Successor != null)
                {
                    Successor.HandleRequest(request, str);
                }
            }
        }


        public override void HandleRequest(ConsoleKeyInfo request, List<char> list, StringBuilder str)
        {
            throw new NotImplementedException();
        }

        public static bool RemoveLastSymbol(StringBuilder StrBuilder)
        {
            if (IsNotEmpty(StrBuilder))
            {
                StrBuilder.Remove(StrBuilder.Length - 1, 1);
                StrBuilder.Append(' '); 
                Console.WriteLine();
                return true;
            }
            return false;
        }
        public static bool IsEmpty(StringBuilder StrBuilder)
        {
            return StrBuilder.Length == 0;
        }

        public static bool IsNotEmpty(StringBuilder StrBuilder)
        {
            return !IsEmpty(StrBuilder);
        }

        public override void HandleRequest(ConsoleKeyInfo request)
        {
            throw new NotImplementedException();
        }
    }
}
