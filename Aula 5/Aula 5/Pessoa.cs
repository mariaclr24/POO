using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    public class Pessoa
    {
        #region Atributos

        int idade; //private (ninguém consegue aceder a idade)
        string nome;
        #endregion

        #region Construtores
        public Pessoa()
        {

        }
        public Pessoa(int idadeParametro, string nomeparametro)
        {
            this.nome = nomeparametro;
            this.idade = idadeParametro;
        }

        #endregion

        #region PropriedadesEmC#
        public int Idade
        {
            get
            {
                if (idade > 0)
                    return idade;
                else
                    return 0;
            }
            set
            {
                this.idade = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;  //.ToUpper();
            }
            set
            {
                this.nome = value;
            }
        }
        #endregion


        #region Metodos A_LA_JAVA
        public int GetIdade()
        {
            return idade;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCurso()
        {
            return "LEIM";
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        #endregion

        //ToString serve para saber os valores dos atributos
        public virtual string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Tiago" +
            //    "" +
            //    "" +
            //    "" +
            //    "" +
            //    "" +
            //    "Tiago" +
            //    "" +
            //    "");

            return "Nome: " + nome + "\nIdade: " + idade;
        }
        #region Destrutor

        /// <summary>
        /// Finalizes an instance of the <see cref="Pessoa"/> class.
        /// </summary>
        ~Pessoa()
        {

        }
        #endregion
    }
}
