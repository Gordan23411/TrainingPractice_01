using System;

class Program
{
    static void Main()
    {
        string password = "1231";
        string a;
        int b = 2;

        for (int i = 0; i< 3; i++)
        {
            Console.WriteLine("Введите пароль для секретного сообщения");
            a = Console.ReadLine();
            if (a == password) 
            {
                Console.WriteLine("Тренируйся больше");
                break;
            }
            else
            {
                Console.WriteLine("Неверный пароль");
                Console.WriteLine($"У вас осталось {a} попыток");
                b -= 1;
            }
        }
    }
}