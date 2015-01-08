namespace DAA.DP.RGR
{
    using System;

    class IntEnterHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (request.Key == ConsoleKey.Enter && IntBackspaceHandler.StrIsNotEmpty())
            {
                Console.WriteLine();
                try
                {
                    InputInt32.Value = int.Parse(InputInt32.Str.ToString());
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.Beep();
            }
        }
    }
}
