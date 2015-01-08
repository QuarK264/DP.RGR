namespace DAA.DP.RGR
{
    using DAA.DP.RGR.DataTime;
    using System;

    class DTBackspaceHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (request.Key == ConsoleKey.Backspace && NumberIsNotEmpty())
            {
                RemoveLastSymbolInNumber();
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }

        private void RemoveLastSymbolInNumber()
        {
            InputDataTime.StrNumber.Remove(InputDataTime.StrNumber.Length - 1, 1);
            Console.Write("\b ");            
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            
        }

        public static bool NumberIsNotEmpty()
        {
            return InputDataTime.StrNumber.Length != 0;
        }
    }
}
