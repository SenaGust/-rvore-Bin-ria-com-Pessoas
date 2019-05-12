using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árvore_Binária_com_Pessoas
{
    class ArvoreBinariaABB
    {
        #region Atributos
        public Nodo Raiz { get; private set; }
        #endregion

        #region Construtor
        public ArvoreBinariaABB()
        {
            this.Raiz = null;
        }
        #endregion


        public void Inserir(IDado Idado)
        {
            Nodo novo = new Nodo(Idado); //recebe o novo dado
            this.Raiz = InserirRecursivo(novo, this.Raiz);

        }
        private Nodo InserirRecursivo(Nodo novo, Nodo raiz)
        {
            if (raiz == null) //insere novo elemento quando a raiz é nula
            {
                return novo;
            }
            if (novo.MeuDado.CompareTo(raiz.MeuDado)<0) //se a raiz for nula a esquerda, insere a esquerda
                raiz.Esquerda = InserirRecursivo(novo, raiz.Esquerda);
            else //se a raiz for nula a direita, insere a direita
                raiz.Direita = InserirRecursivo(novo, raiz.Direita);
            return raiz;
        }


        #region Buscar
        public IDado Buscar(string chave)
        {
            return null;
        }
        private Nodo BuscaRecursiva(Nodo busca, Nodo raiz)
        {
            return null;
        }
        #endregion

        #region Retirar
        public IDado Retirar(string nome)
        {
            return null;
        }
        public Nodo RetiradaRec(Nodo quem, Nodo onde, out Nodo saida)
        {
            saida = null;
            return null;
        }
        #endregion

       
        public override string ToString()
        {
            return EmOrdem(this.Raiz);
        }
        private string EmOrdem(Nodo raiz) //método que vai imprimir a árvore bonitinha
        {
            if (raiz != null)
            {
                String aux = "   ";
                aux = "   " + EmOrdem(raiz.Esquerda);
                aux += "   " + raiz.ToString();
                aux += "   " + EmOrdem(raiz.Direita);
                return ("\n" + aux);
            }
            else return "";
        }


    } 
}
