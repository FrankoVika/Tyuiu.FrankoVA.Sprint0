﻿using Tyuiu.FrankoVA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.FrankoVA.Sprint0.Task6.V0_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива =" + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
