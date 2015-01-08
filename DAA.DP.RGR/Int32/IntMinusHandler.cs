namespace DAA.DP.RGR
{
    using System;

    class IntMinusHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (request.KeyChar == '-')
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
