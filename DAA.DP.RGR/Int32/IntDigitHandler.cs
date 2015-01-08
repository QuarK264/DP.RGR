namespace DAA.DP.RGR
{
    using System;

    class IntDigitHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (InputInt32.CorrectDigits.Contains(request.KeyChar))
            {
                InputInt32.Str.Append(request.KeyChar);
                Console.Write(request.KeyChar);
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
