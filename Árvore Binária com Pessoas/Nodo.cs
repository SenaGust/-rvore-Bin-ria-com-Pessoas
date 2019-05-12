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
            if (Esquerda != null)
                if (Direita != null)
                    return 2; //possui os dois filhos
                else
                    return -1; //filho deve ser mandado para a esquerda
            else if (Direita != null)
                return 1; //filho deve ser mandado para a direita
            else
                return 0; //não possui filhos
        }

        public Nodo Antecessor()  
        {
            Nodo aux = Esquerda; 

            while (aux.Direita != null)
                aux = aux.Direita;

            return aux; //retorna o último elemento da direita
        }
        #endregion
    }
}
