﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Сколько у вас золота?: ");
        int gold = int.Parse(Console.ReadLine());

        Console.Write("Введите рыночную стоимость одного кристалла: ");
        int CenaCrystal = int.Parse(Console.ReadLine());

        int crystal = gold / CenaCrystal;
        gold -= crystal * CenaCrystal;

        Console.WriteLine($"Количество купленных кристаллов: {crystal}");
        Console.WriteLine($"Остаток золота: {gold}");
    }
}