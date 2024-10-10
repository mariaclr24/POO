//-----------------------------------------------------------------
//    <copyright file="Aula_1.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-10</date>
//    <time>16:01</time>
//    <version>0.1</version>
//    <author>Maria Rodrigues</author>
//    <description> Aula 4- Classes</description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula_4
{
    internal class Program
    {
        public class Pessoa
        {
            //atributos da classe
            public int Id { get; set; }

            public string Nome { get; set; } = string.Empty;

            public Pessoa(string nome)
            {
            }

            public int SomaDoisValores(int x, int y)
            {
                return x + y;
            }

            public static int SomaDoisValoresEstatico(int x, int y)
            {
                return x + y;
            }
            public class Funcionario
        {
            #region Atributos

            public string nome;
            public int idade;
            public double salario;

            #endregion

            #region Construtores

            public Funcionario()
            {
            }

            public Funcionario(string nomeParametro, int idadeParametro)
            {
                this.nome = nomeParametro;
                this.idade = idadeParametro;
            }

            public Funcionario(string nomeParametro, int idadeParametro, double salarioParametro)
            {
                this.nome = nomeParametro;
                this.idade = idadeParametro;
                this.salario = salarioParametro;
            }



            #endregion

        }
        static void Main(string[] args)
        {

            #region Teste da classe Funcionario

            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Tiago";
            funcionario.idade = 40;

            Console.Write("\n1º Exemplo, Nome: {0}, Idade: {1}", funcionario.nome, funcionario.idade);

            Funcionario funcionario1 = new Funcionario("Paulo", 45, 900.6);

            Console.Write("\n1º Exemplo, Nome: {0}, Idade: {1} e Salário: {2}", funcionario1.nome, funcionario1.idade, funcionario1.salario);

            #endregion

            Console.ReadKey();

        }

    }
}