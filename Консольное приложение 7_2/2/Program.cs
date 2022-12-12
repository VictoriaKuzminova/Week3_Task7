using System;


namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            while (true)
            {
                try
                {
                    Console.Write("Введите строку: ");
                    str = Console.ReadLine();
                    //Проверка на пустоту
                    if (String.IsNullOrWhiteSpace(str))
                    {
                        Console.WriteLine("Строка пустая");
                        continue;
                    }
                    break;
                }
                catch { }
            }
            //Замена на одиночный пробел
            str = str.Replace("  ", " ");
            //Создание массивов из подстрок
            string[] slova = str.Split(' ');
            for (int i = 0; i < slova.Length; i++)
            {
                //Поиск однобуквенного слова
                if (slova[i].Length != 1)
                    Console.Write(slova[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
