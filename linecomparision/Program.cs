﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linecomparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Find two lines are equal or not
            
            int x1, y1, x2, y2, x3, y3, x4, y4;
            double Length1;
            double Length2;

            
            Console.WriteLine("x1 value:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 value:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 value:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 value:");
            y2 = Convert.ToInt32(Console.ReadLine());


            
            Console.WriteLine("x3 value:");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y3 value:");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x4 value:");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y4 value:");
            y4 = Convert.ToInt32(Console.ReadLine());

            //Formula
            Length1 = Math.Sqrt((x2 - x1 ^ 2 + y2 - y1 ^ 2));
            Length2 = Math.Sqrt((x4 - x3 ^ 2 + y4 - y4 ^ 2));

            if (Length1 == Length2)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }

            Console.ReadLine();

        }
    }
}
