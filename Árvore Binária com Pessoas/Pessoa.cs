using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árvore_Binária_com_Pessoas
{
    class Pessoa : IDado
    {
        #region Atributos
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public char Sexo { get; private set; }
        public double Peso { get; private set; }
        #endregion

        #region Construtor
        public Pessoa(string nome, int idade, char sexo, double peso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Peso = peso;
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return string.Format("Nome: {0} Sexo: {1} Idade: {2} Peso: {3}", this.Nome, this.Sexo, this.Idade, this.Peso);
        }

        public int CompareTo(object obj)
        {
            Pessoa pessoa_aux = (Pessoa)(obj);
            return (string.Compare(this.Nome, pessoa_aux.Nome));
        }

        #endregion
    }
}
