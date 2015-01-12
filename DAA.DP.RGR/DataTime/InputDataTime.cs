namespace DAA.DP.RGR.DataTime
{
    using System;
    using System.Globalization;
    using System.Text;

    public static class InputDataTime
    {
        private static StringBuilder strNumber = new StringBuilder();
        private static uint number;

        public static StringBuilder StrNumber
        {
            get
            {
                return strNumber;
            }
            set
            {
                strNumber = value;
            }
        }

        public static uint Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        internal static DateTime DataTime(string msg)
        {
            Console.WriteLine(msg);
            uint firstNumber = 0;
            uint secondNumber = 0;
            uint thirdNumber = 0;
            Console.WriteLine();
            do
            {
                firstNumber = InputNumber();
            }
            while (firstNumber < DateTime.MinValue.Month && firstNumber < DateTime.MinValue.Day);
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            do
            {
                secondNumber = InputNumber();
            }
            while (secondNumber < DateTime.MinValue.Month && secondNumber < DateTime.MinValue.Day);
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            do
            {
                thirdNumber = InputNumber();
            }
            while (thirdNumber == 0 && thirdNumber <= DateTime.MaxValue.Year && thirdNumber >= DateTime.MinValue.Year);
            uint day = 0;
            uint month = 0;
            uint year = 0;
            Console.WriteLine();

            SortNumbers(firstNumber, secondNumber, thirdNumber, ref day, ref month, ref year);
            string date = string.Format("{0}/{1}/{2} 00:00:00", day, month, year);
            DateTime datetime;
            string[] formats = { "dd/MM/yyyy hh:mm:ss", "d/MM/yyyy hh:mm:ss", "dd/M/yyyy hh:mm:ss",
                                 "d/M/yyyy hh:mm:ss", "dd/MM/yy hh:mm:ss tt", "d/MM/yy hh:mm:ss",
                                 "dd/M/yy hh:mm:ss", "d/M/yy hh:mm:ss", "MM/dd/yyyy hh:mm:ss", "M/dd/yyyy hh:mm:ss",
                                 "MM/d/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss" };
            try
            {
                foreach (string format in formats)
                {
                    if (DateTime.TryParseExact(date, format, new CultureInfo("en-US", false), DateTimeStyles.None, out datetime))
                    {
                        return DateTime.ParseExact(date, format, new CultureInfo("en-US", false), DateTimeStyles.None);
                    }
                }
                throw new FormatException("Дату неальзя отобразить ни в одном из доступных форматов.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name + " " + e.Message);
            }
            return DateTime.Parse(date);
        }

        private static void SortNumbers(uint firstNumber, uint secondNumber, uint thirdNumber, ref uint day, ref uint month, ref uint year)
        {
            if ((firstNumber > 12 && secondNumber > 12 && thirdNumber > 12) || (firstNumber > 31 && secondNumber > 31 && thirdNumber > 31))
            {
                DataTime("Дата введена не верно, пожалкйста введите заново.");
            }
            else
            {
                if (firstNumber <= 12 && secondNumber <= 12 && thirdNumber <= 12)
                {
                    if (firstNumber <= 12 && secondNumber <= 12 && CultureInfo.CurrentCulture.Name == "en-US")
                    {
                        year = thirdNumber;
                        month = firstNumber;
                        day = secondNumber;
                    }
                    else
                    {
                        year = thirdNumber;
                        month = secondNumber;
                        day = firstNumber;
                    }
                }
                else
                {
                    if (firstNumber > 12 && secondNumber <= 12 && thirdNumber > 12)
                    {
                        month = secondNumber;
                        if (firstNumber < thirdNumber)
                        {
                            day = firstNumber;
                            year = thirdNumber;
                        }
                        else
                        {
                            year = firstNumber;
                            day = thirdNumber;
                        }
                    }
                    else
                    {
                        if (firstNumber <= 12 && secondNumber > 12 && thirdNumber > 12)
                        {
                            month = firstNumber;
                            if (secondNumber > thirdNumber)
                            {
                                year = secondNumber;
                                day = thirdNumber;
                            }
                            else
                            {
                                day = secondNumber;
                                year = thirdNumber;
                            }
                        }
                        else
                        {
                            month = secondNumber;
                            if (firstNumber > thirdNumber)
                            {
                                year = firstNumber;
                                day = thirdNumber;
                            }
                            else
                            {
                                day = firstNumber;
                                year = thirdNumber;
                            }
                        }
                    }
                }
            }
        }

        private static uint InputNumber()
        {
            InputDataTime.StrNumber.Clear();
            InputDataTime.Number = 0;
            ConsoleKeyInfo KeyInfo;
            Handler digitHandler = new DTDigitHandler();
            Handler backspaceHandler = new DTBackspaceHandler();
            Handler enterHandler = new DTEnterHandler();
            digitHandler.SetSuccessor(backspaceHandler);
            backspaceHandler.SetSuccessor(enterHandler);
            do
            {
                KeyInfo = Console.ReadKey(true);
                digitHandler.HandleRequest(KeyInfo);
            }
            while (KeyInfo.Key != ConsoleKey.Enter || DTEnterHandler.TooLongNumberFlag);
            return Number;
        }
    }
}
