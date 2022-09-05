using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Водка, Пиво, Конец, Корпоратив";
            char[] sep = { ' ' };
            string[] parts = str.Split(sep);
            int max = 0, ind = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > max)
                {
                    max = parts[i].Length;
                    ind = i;
                }
            }
            Console.WriteLine(parts[ind]);
            Console.ReadLine();
        }
        
    }
}
