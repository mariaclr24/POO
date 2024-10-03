//-----------------------------------------------------------------
// <copyright file="Aula_2.cs" company="IPCA">
// Copyright (c) IPCA-EST 2024. All rights reserved.
// </copyright>
// <date>2024-10-02</date>
// <time>16:00</time>
// <version>0.1</version>
// <author></Maria Rodrigues-28038>
// <description>< Aula 2 - Classes, atributos, métodos, acessos , namespace e Nota POO>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static double Media(double x, double y)
        {
            return (0.4 * x) + (0.6 * y);
        }
        static void Main(string[] args)
        {
            //uma linha de comentário
            /*
             * 
             * comentário
             * 
             */
            // int    exemplo: idade, 1, 10
            // double exemplo:comprimento, 25,5 m
            // string exemplo: "Aula POO"
            // bool   exemplo: if(Étarde) true/false


            double ct=0, cp=0, uc=0;

            //console.write deixa o utilizador escrever a frente da frase e não em baixo ao contrário do console.writeline


            Console.Write("\nDigite a nota da Componente Teorica (CT):");
            ct = double.Parse(Console.ReadLine());
            // double.parse é um conversor para double
            // console.readline só aceita texto (string)

            Console.Write("\nDigite a nota da Componente Pratica (CP):");
            cp = double.Parse(Console.ReadLine());

            uc=Media(cp, ct);

            // Console.WriteLine("Nota da UC POO:{0}", uc);
            // se tivesse mais um valor: Console.WriteLine("NF:{0}, outro valor: {1}", uc, outroValor);

            Console.WriteLine("NF: " + Math.Round(uc, 2));
            // O método Math.Round(uc, 2) arredonda o número uc para duas casas decimais.
            // Console.WriteLine("NF: " + uc + ", outro valor: " + outroValor); outra forma de fazer.

            Console.ReadKey();
        }
    }

}

