﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int maxCountLeft = ResultFromLeft(firstArray, secondArray);
            int maxCountRight = ResultFromRight(firstArray, secondArray);
            if (maxCountLeft == 0 && maxCountRight == 0)
            {
                Console.WriteLine(0);
            }
            else if (maxCountLeft > maxCountRight)
            {
                Console.WriteLine(maxCountLeft);
            }
            else
            {
                Console.WriteLine(maxCountRight);
            }
        }
        public static int ResultFromLeft(string[] firstArray, string[] secondArray)
        {
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            int counter = 0;
            int maxCount = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;

                }
                else
                {
                    if (maxCount < counter)
                    {
                        maxCount = counter;
                    }
                    counter = 0;
                }

            }
            if (maxCount < counter)
            {
                maxCount = counter;
            }
            return maxCount;
        }
        public static int ResultFromRight(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int maxCount = 0;
            if (firstArray.Length > secondArray.Length)
            {
                int longArrayIndex = firstArray.Length - 1;
                for (int i = secondArray.Length - 1; i >= 0; i--)
                {
                    if (firstArray[longArrayIndex] == secondArray[i])
                    {
                        count++;

                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longArrayIndex--;
                }
                
            }
            
            else
            {
                int longArrayIndex = secondArray.Length - 1;
                for (int i = firstArray.Length - 1; i >= 0; i--)
                {
                    if (secondArray[longArrayIndex] == firstArray[i])
                    {
                        count++;

                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 0;
                    }
                    longArrayIndex--;
                }
               

            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            return maxCount;
        }

    }
}

