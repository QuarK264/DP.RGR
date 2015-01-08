namespace DAA.DP.RGR
{
    using DAA.DP.RGR.DataTime;
    using System;

    class DTEnterHandler : Handler
    {
        public static bool TooLongNumberFlag { get; private set; }

        public override void HandleRequest(ConsoleKeyInfo request)
        {
            TooLongNumberFlag = false;
            if (InputDataTime.StrNumber.Length <= 4)
            {
                if (request.Key == ConsoleKey.Enter && DTBackspaceHandler.NumberIsNotEmpty())
                {
                    InputDataTime.Number = uint.Parse(InputDataTime.StrNumber.ToString());
                }
                else
                {
                    Console.Beep();
                }
            }
            else
            {
                TooLongNumberFlag = true;
                Console.Beep();
            }
        }
    }
}
