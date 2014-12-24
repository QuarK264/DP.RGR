using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.RGR
{
    public static class Input
    {
        internal static int Int32(string msg)
        {
            Console.WriteLine(msg);
            ConsoleKeyInfo KeyInfo;
            List<char> CorrectDigits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
            Handler digitHandler = new DigitHandler();
            Handler backspaceHandler = new BackspaceHandler();
            Handler enterHandler = new EnterHandler();
            digitHandler.SetSuccessor(backspaceHandler);
            backspaceHandler.SetSuccessor(enterHandler);
            StringBuilder str = new StringBuilder();

            while (true)
            {
                KeyInfo = Console.ReadKey(true);
                digitHandler.HandleRequest(KeyInfo, CorrectDigits, str);
            }
        }

        public static void ClearConsoleLine()
        {
            var str = new string('\b', Console.CursorLeft);
            Console.Write(str);
        }

        
    }
}
