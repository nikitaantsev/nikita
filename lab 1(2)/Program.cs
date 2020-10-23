using System;
namespace lr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int R;
            int x = 2;
            int y = 1;
            int z = 4;

            R = 0;
            Console.WriteLine("Значение переменной y равно 1", y);
            Console.WriteLine("Значение переменной x равно 2", x);
            Console.WriteLine("Значение переменной z равно 4", z);
            Console.WriteLine("выводится решение операции а именно (2 * x + 2 * y - 4 * y - 4 * x * y + z)");
            int Result = 2 * x + 2 * y - 4 * y - 4 * x * y + z;
            Console.WriteLine(Result);
            Console.WriteLine("выведен результат R=-2");
            Console.WriteLine("для завершения работы программы нажмите любую клавишу...");

            Console.ReadKey();

        }
    }
}
