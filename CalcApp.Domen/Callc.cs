﻿namespace CalcApp.Domen;
public class Calc
{

    // Метод для сложения двух чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    // Метод для деления двух чисел
    public double Divide(int a, int b)
    {
        return a / b;
    }
}
