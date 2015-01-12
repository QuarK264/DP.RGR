namespace DAA.DP.RGR
{
    using DataTime;
    using System;

    class Program
    {
        static void Main()
        {
            int value = InputInt32.Int32("Введите целое число:");
            Console.WriteLine(value);
            DateTime date = InputDataTime.DataTime("Введите желаемую дату:"); 
            Console.WriteLine("Вы ввели дату: {0}. Нажмите любую клавишу для завершения программы.", date);
            
            Console.ReadKey(true);
        }
    }
}
