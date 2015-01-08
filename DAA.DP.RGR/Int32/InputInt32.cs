namespace DAA.DP.RGR
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class InputInt32
    {
        private static List<char> correctDigits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private static StringBuilder str = new StringBuilder();
        private static int _value;

        public static List<char> CorrectDigits
        {
            get
            {
                return correctDigits;
            }
        }

        public static StringBuilder Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }

        public static int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        internal static int Int32(string msg)
        {
            Console.WriteLine(msg);
            ConsoleKeyInfo KeyInfo;
            Handler minusHandler = new IntMinusHandler();
            Handler digitHandler = new IntDigitHandler();
            Handler backspaceHandler = new IntBackspaceHandler();
            Handler enterHandler = new IntEnterHandler();
            minusHandler.SetSuccessor(digitHandler);
            digitHandler.SetSuccessor(backspaceHandler);
            backspaceHandler.SetSuccessor(enterHandler);

            do
            {
                KeyInfo = Console.ReadKey(true);
                if (str.ToString().Contains('-'))
                {
                    digitHandler.HandleRequest(KeyInfo);
                }
                else
                {
                    minusHandler.HandleRequest(KeyInfo);
                }
            }
            while (KeyInfo.Key != ConsoleKey.Enter);
            return Value;
        }
    }
}
