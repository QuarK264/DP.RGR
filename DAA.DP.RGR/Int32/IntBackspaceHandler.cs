namespace DAA.DP.RGR
{
    using System;

    class IntBackspaceHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (request.Key == ConsoleKey.Backspace && StrIsNotEmpty())
            {
                RemoveLastSymbol();
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }

        private void RemoveLastSymbol()
        {
            InputInt32.Str.Remove(InputInt32.Str.Length - 1, 1);
            Console.Write("\b ");            
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            //Console.SetCursorPosition(Input32.Str.Length, Console.CursorTop);
        }

        public static bool StrIsNotEmpty()
        {
            return InputInt32.Str.Length != 0;
        }
    }
}
