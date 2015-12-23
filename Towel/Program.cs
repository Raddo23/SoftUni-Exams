﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int width = int.Parse(Console.ReadLine());
             int height = (int) Math.Floor(width * 1.5);
             string[] output = ;

             for (int i = 0; i < 51; i++)
             {
                 output[i] = "#..";
             }*/

            int width = int.Parse(Console.ReadLine());
            int height = (int)Math.Floor(width * 1.5);

            int totalSymbolsCount = width * height;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if ((row + col) % 3 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
            }
        }
    }
    }

