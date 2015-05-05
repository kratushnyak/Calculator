using System;

namespace @while
{
    class Program
    {
        static void Main()
        {
            var prog = new Program();
            string f, s, a;
            double x, y;
            prog.MethodInfo("                  КАЛЬКУЛЯТОР !!!!!!!");
            Console.WriteLine();
            prog.MethodInfo("Чтобы выйти из калькулятора нажмите: 'q'");

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    prog.MethodInfo("введите первое число:  ");
                    f = Console.ReadLine();
                    if (f == "q") break;
                    if (f != null)
                    {
                        x = float.Parse(f);

                        prog.MethodInfo("введите второе число:  ");
                        s = Console.ReadLine();
                        if (s == "q") break;
                        if (s != null)
                        {
                            y = float.Parse(s);

                            prog.MethodInfo("выберите действие из предложенных: ('+', '-', '/', '*'):  ");
                            a = Console.ReadLine();
                            switch (a)
                            {
                                case "+": Console.WriteLine(f + "+" + s + "=" + (x + y)); break;
                                case "-": Console.WriteLine(f + "-" + s + "=" + (x - y)); break;
                                case "*": Console.WriteLine(f + "*" + s + "=" + x * y); break;
                                case "/": if (s == "0" && a == "/")
                                {
                                    prog.MethodError("деление на ноль не возможно!!!");
                                    break;
                                }
                                    Console.WriteLine(f + "/" + s + "=" + x / y); break;
                                default: prog.MethodError("Вы ввели не допустимый знак действия!!!!!"); break;
                            }
                        }
                    }
                }
                catch
                {
                    prog.MethodError("Вы ввели не допустимые значение!!!!!!!!");
                }
            }
        }

        public string MethodError(string col)
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(col);
            Console.ForegroundColor = ConsoleColor.White;
            return col;
        }

        public string MethodInfo(string col)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(col);
            Console.ForegroundColor = ConsoleColor.White;
            return col;
        }
    }
}
