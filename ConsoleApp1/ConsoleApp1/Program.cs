﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] integers = new int[] { 1, 2, 3, 4, 5, 6 };

Console.WriteLine(GetAverage(integers));
static double GetAverage(int[] ints)
{
    double sum = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        sum = (double)ints[i] + sum;
    }

    return sum / ints.Length;
}