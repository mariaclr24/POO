using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    //Herança estamos a herdar os atributos criados na classe pessoa Colaborador:Pessoa
    public class Colaborador : Pessoa
    {
        #region Atributos

        double salario;

        #endregion

        #region Contrutores

        //Herança altera a classe contrutora Pessoa
        public Colaborador(double salario, string nomeParametro, int idadeParametro) : base(idadeParametro, nomeParametro)
        {
            this.salario = salario;
            base.Idade = idadeParametro;
            base.Nome = nomeParametro;
        }
        //Polimorfismo nao mexe na classe Pessoa

        //public Colaborador(double salario, string nome, int idade)
        //{
        //    this.salario = salario;
        //    base.Idade = idade;
        //    base.Nome = nome;
        //}

        #endregion
        public override string ToString()
        {
            return "Nome: " + base.Nome
                + "\nIdade: " + base.Idade
                + "\nSalario: " + this.salario.ToString();
        }
    }
}
