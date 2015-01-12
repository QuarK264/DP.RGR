namespace DAA.DP.RGR
{
    using DAA.DP.RGR.DataTime;
    using System;

    class DTDigitHandler : Handler
    {
        public override void HandleRequest(ConsoleKeyInfo request)
        {
            if (InputInt32.CorrectDigits.Contains(request.KeyChar) && InputDataTime.StrNumber.Length <= 3)
            {
                InputDataTime.StrNumber.Append(request.KeyChar);
                Console.Write(request.KeyChar);
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
