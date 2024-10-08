//-----------------------------------------------------------------
// <copyright file="Aula_3.cs" company="IPCA">
// Copyright (c) IPCA-EST 2024. All rights reserved.
// </copyright>
// <date>2024-10-03</date>
// <time>16:00</time>
// <version>0.1</version>
// <author></Maria Rodrigues-28038>
// <description>< Aula 3 - Classes, atributos, métodos, acessos , namespace e Nota POO>
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    internal class Program
    {
        #region ZonadeTeste
        static void Main(string[] args)
        {
            //Calculadora 
            //Opções: +, -, *, /
            //Pedir apena dois valores 
            //Mostrar resultado arredondado a 2 casas
            //segundo valor e utilizado como denominador

            // Variaveis 
            double x = 0.0, y = 0.0, z = 0.0;
            string escolha = "";
            bool escolhax = false;

            Console.WriteLine("Calculadora");

            //Ler e Escrever
            Console.Write("Escolha a operação possível (+,-, *, /):");
            escolha = Console.ReadLine();

            Console.Write("Digite o primeiro valor:");
            x= double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            y= double.Parse(Console.ReadLine());

            if(escolha == "+")
            {
                z = x + y;
                Console.WriteLine("Soma:" + z);
            }
            else if(escolha == "-")
            {
                z= x - y;
                Console.WriteLine("Subtração:" + z);
            }
            else if (escolha == "*")
            {
                z = x * y;
                Console.WriteLine("Multiplicação:" + z);
            }
            else if(escolha == "/") 
            {
                if(y> 0)
                {
                    Console.WriteLine("Segundo valor tem de ser maior que zero");
                }
                else
                {
                    z = x / y;
                    Console.WriteLine("Divisão:" + z);
                }
                
            }
            else
            {
                Console.WriteLine("Opção inválida");
                escolhax= true;
            }

            /*
            
            OU
             
            double primeiroValor = 0.0, segundoValor = 0.0, valorFinal = 0.0;
            string escolha = "";
            bool bIncorreto = true;

            //Ler e escrever
            Console.WriteLine("1º valor: ");
            primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("2º valor: ");
            segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação possivel (+, -, *, /): ");
            escolha = Console.ReadLine();


            if (escolha == "+")
            {
                valorFinal = primeiroValor + segundoValor;
            }
            else if (escolha == "-")
            {
                valorFinal = primeiroValor - segundoValor;
            }
            else if (escolha == "*")
            {
                valorFinal = primeiroValor * segundoValor;
            }
            else if (escolha == "/")
            {
                if(segundoValor > 0)
                {
                    valorFinal = primeiroValor / segundoValor;
                } 
                else
                {
                    bIncorreto = false;
                }
            }
            else
            {
                Console.WriteLine("Opção incorreta");
                bIncorreto = false;
            }

            if (bIncorreto)
            {
                Console.WriteLine("Resultado: {0}", valorFinal);
            }
            */

        }
        #endregion
    }
}
