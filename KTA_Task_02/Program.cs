using System;

class Program
{
    static void Main()
    {
        string word;
        Console.WriteLine("Введите слово начать");

        do
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Хотитье продолжить выполнение программ?\n" + "Если нет, то введите слово Exit\n" + "Есди да, то введите любой другой символ");
            word = Console.ReadLine();
        }
        while (word.ToLower() != "Exit");
    }
}