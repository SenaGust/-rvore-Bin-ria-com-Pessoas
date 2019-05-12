using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árvore_Binária_com_Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinariaABB arvore = new ArvoreBinariaABB();

            arvore.Inserir(new Pessoa("Lorena", 20, 'F', 53));
            arvore.Inserir(new Pessoa("Gustavo", 20, 'M', 76));
            arvore.Inserir(new Pessoa("João", 19, 'M', 65));
            arvore.Inserir(new Pessoa("Nathan", 19, 'M', 76));
            arvore.Inserir(new Pessoa("Cristiano", 20, 'M', 76));
            arvore.Inserir(new Pessoa("Luana", 15, 'F', 43));
            arvore.Inserir(new Pessoa("Matheus", 25, 'M', 80));
            arvore.Inserir(new Pessoa("Núbia", 35, 'F', 65));
            arvore.Inserir(new Pessoa("Paulo", 65, 'M', 80));
            arvore.Inserir(new Pessoa("Beatriz", 20, 'F', 60));

            Console.WriteLine(arvore.ToString());
            Console.ReadKey();
        }
    }
}
