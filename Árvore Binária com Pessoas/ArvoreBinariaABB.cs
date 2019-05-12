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

        }
        #endregion

        #region Inserir
        public void Inserir(IDado dado)
        {

        }
        private Nodo InserirRecursivo(Nodo novo, Nodo raiz)
        {
            return null;
        }
        #endregion

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

        #region Imprimir
        public override string ToString()
        {
            return EmOrdem(this.Raiz);
        }
        private string EmOrdem(Nodo raiz)
        {
            return null;
        }
        #endregion
    }
}
