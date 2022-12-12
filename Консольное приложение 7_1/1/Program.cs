using System;

namespace _1
{
    class Program
    {
        static string remove(string str)
        {
            //Проверка на четность символов
            if (str.Length % 2 == 0)
            {
                //Удаление
                return str.Remove(str.Length / 2 - 1, 2);
            }
            //Если количество символов нечетное, удаление одного символа
            return str.Remove(str.Length / 2, 1);
        }
        static void Main(string[] args)
        {
            
            string str;
            //Проверка на пустоту
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите строку:  ");
                    str = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(str))
                    {
                        Console.WriteLine("Строка пустая");
                        continue;
                    }
                    break;
                }
                catch { }
            }
            Console.WriteLine("Количество символов: "+str.Length);
            Console.WriteLine("{0}", remove(str));
            Console.ReadLine();
        }
    }
}
