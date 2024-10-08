//-----------------------------------------------------------------
// <copyright file="Aula_3.cs" company="IPCA">
// Copyright (c) IPCA-EST 2024. All rights reserved.
// </copyright>
// <date>2024-10-03</date>
// <time>16:00</time>
// <version>0.1</version>
// <author></Maria Rodrigues-28038>
// <description>< Exercicios>
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1,2,3,4");

            Console.Write("1,");
            Console.Write("2,");
            Console.Write("3,");
            Console.WriteLine("4");
            // o console.writeline dá automaticamente um /n

            for(int i = 1;i<=4;i++)
            {
                if(i == 4)
                {
                    Console.Write("4\n");
                }
                else
                {
                    Console.Write(i + ",");
                }
            }

            System.Console.WriteLine("*\n**\n***\n****\n*****");

            for(int i = 0;i<=5;i++)
            {
                for(int j = 0;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
