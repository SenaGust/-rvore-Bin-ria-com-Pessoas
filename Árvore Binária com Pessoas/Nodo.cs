using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árvore_Binária_com_Pessoas
{
    class Nodo
    {
        #region Atributos
        public IDado MeuDado { get; set; }
        public Nodo Esquerda { get; set; }
        public Nodo Direita { get; set; }
        #endregion

        #region Construtor
        public Nodo(IDado dado)
        {
            MeuDado = dado;
            Esquerda = Direita = null;
        }
        #endregion

        #region Métodos
        public int Grau()
        {
            return 0;
        }

        public Nodo Antecessor()
        {
            return null;
        }
        #endregion
    }
}
