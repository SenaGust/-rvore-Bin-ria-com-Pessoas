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
                return novo;

            else
            {
                if (novo.MeuDado.CompareTo(raiz.MeuDado) < 0) //se a raiz for nula a esquerda, insere a esquerda
                    raiz.Esquerda = InserirRecursivo(novo, raiz.Esquerda);
                else //se a raiz for nula a direita, insere a direita
                    raiz.Direita = InserirRecursivo(novo, raiz.Direita);
            }
            return raiz;
        }


        #region Buscar
        public IDado Buscar(string nome)
        {
            Nodo busca = new Nodo(new Pessoa(nome,0,' ',0));
            return BuscaRecursiva(busca, Raiz).MeuDado;
        }
        private Nodo BuscaRecursiva(Nodo busca, Nodo raiz)
        {
            if (raiz == null)
                return null;

            if (busca.MeuDado.CompareTo(raiz) == 0)
                return Raiz;
            else if (busca.MeuDado.CompareTo(raiz) < 0)
                return BuscaRecursiva(busca, raiz.Esquerda);
            else
                return BuscaRecursiva(busca, raiz.Direita);
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

        #region Paster
        public string a()
        {
            double mulheres = 0, homens = 0, total = 0; 
            ContabilizaHomens(Raiz, ref mulheres, ref homens, ref total);
            return ("Homens: " + homens + " \nMédia de idade das mulheres: " + (total/mulheres));
        }

        private int ContabilizaHomens(Nodo raiz, ref double mulheres, ref double homens, ref double totalIdade)
        {
            if (raiz != null)
            {
                Pessoa pessoa = (Pessoa)(raiz.MeuDado);
                if (char.ToUpper(pessoa.Sexo) == 'M')
                {
                    homens++;
                    return ContabilizaHomens(raiz.Direita,ref mulheres,ref homens,ref totalIdade) + ContabilizaHomens(raiz.Esquerda, ref mulheres, ref homens,ref totalIdade);
                }
                else
                {
                    mulheres++;
                    totalIdade += pessoa.Idade;
                    return ContabilizaHomens(raiz.Direita, ref mulheres, ref homens, ref totalIdade) + ContabilizaHomens(raiz.Esquerda, ref mulheres, ref homens, ref totalIdade);
                }
                    
            }
            else
                return 0;
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
                StringBuilder aux = new StringBuilder();
                aux.Append(EmOrdem(raiz.Esquerda));
                aux.Append(raiz.MeuDado.ToString());
                aux.Append(EmOrdem(raiz.Direita));
                return (aux.ToString());
            }
            else return "";
        }
        private string imprimeArvore(Nodo raiz) //método que vai imprimir a árvore bonitinha
        {
            if (raiz != null)
            {
                String aux = "   ";
                aux = "   " + EmOrdem(raiz.Esquerda);
                aux += "   " + raiz.MeuDado.ToString();
                aux += "   " + EmOrdem(raiz.Direita);
                return ("\n" + aux);
            }
            else return "";
        }

    } 
}
