﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());

            long[][] matrix = new long[height][];
            long leftDiagonalSum = 0;
            long rightDiagonalSum = 0;

            for (int i = 0; i < height; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                leftDiagonalSum += matrix[i][i];
                rightDiagonalSum += matrix[i][matrix[i].Length - 1 - i];

            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
