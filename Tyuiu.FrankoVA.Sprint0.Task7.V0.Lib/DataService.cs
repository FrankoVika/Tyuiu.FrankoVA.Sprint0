﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FrankoVA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resultArrey = new int[5];
            for (var i = 0; i < resultArrey.Length; i++)
            {
                resultArrey[i] = numOne[i] + numTwo[i];
            }
            return resultArrey;
        }
    }
}
