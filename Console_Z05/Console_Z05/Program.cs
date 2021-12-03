using System;

namespace Console_Z05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Нахождение Y если X принадлежит A,B.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите промежуток.");
                    Console.Write("| A : ");
                    double a = Convert.ToDouble(Console.ReadLine()); ;
                    Console.Write("| B : ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("| Введите шаг.");
                    Console.Write("| H : ");
                    double h = Convert.ToDouble(Console.ReadLine());

                    if (a < b)
                    {
                        if (h > 0)
                        {
                            Console.WriteLine("|----------------------------------");
                            while (a <= b)
                            {
                                f(a);
                                a = a + h;
                            }

                            Console.WriteLine("|----------------------------------");
                            rep(out repit);
                        }
                        else
                        {
                            throw new Exception("H должно быть больше 0!");
                        }
                    }
                    else
                    {
                        throw new Exception("A должно быть меньше B!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("|----------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
                catch (Exception e)
                {
                    Console.WriteLine("|----------------------------------");
                    Console.WriteLine($"| {e.Message}");
                    rep(out repit);
                }
            }
        }
        static void f(double x)
        {
            try
            {
                if (x != 0.25 && x != 1)
                {
                    double y = 1 / (x - 1) + 2 / (1 - 4 * x);
                    Console.WriteLine("| x {0} = y {1}", Math.Round(x, 3), Math.Round(y, 3));
                }
                else
                    throw new Exception("X не должен быть равен {0}!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"| {e.Message}", Math.Round(x, 3));
            }
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|----------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|----------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}
