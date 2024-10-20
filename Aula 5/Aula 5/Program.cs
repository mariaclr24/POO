//-----------------------------------------------------------------
//    <copyright file="Aula_1.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date><2024-10-10>
//    <time><16:01>
//    <version>0.1</version>
//    <author><Maria Rodrigues>
//    <description><Aula 5- Herança, Polimorfismo, propriedades, virtual, override, interface e URL>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code spell checker ou spell checker
            //Ou GhostDOC
            //Herança, Polimorfismo, propriedades, virtual, override, interface e URL

            string birthday;


            Pessoa pessoa = new Pessoa();

            //Propriedades
            pessoa.Idade = 20;
            Console.Write($"Idade: {pessoa.Idade}");
            //pessoa.idade nao é possivel pois idade é privada se fosse public ja dava


            //Metodos
            pessoa.SetIdade(20);
            pessoa.GetIdade();
           

            Console.ReadKey();
        }
    }
}
