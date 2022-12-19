using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
            Random r = new Random();
            int pos = r.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";
            while (tentativas < 3 && flag==false) 
            {
                Console.WriteLine("PErgunta: " + pergunta.Pergunta);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                if (resposta == pergunta.Resposta) 
                {
                    flag = true;
                }
                else 
                {
                    Console.WriteLine("Errou!!!"+pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true) 
            {
                Console.WriteLine("Parabens!!! VocÊ acertou.");
            }
            else 
            {
                Console.WriteLine("Que pena!!! VocÊ perdeu o jogo.");
            }
            Console.ReadKey();
        }

        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            NovaPergunta p = new NovaPergunta("Qual é a cor do céu?", "Azul", "Informe uma cor que comece com a letra A");
            lista.Add(p);
            p = new NovaPergunta("Qual é o maior site de busca?", "Google", "Informe o site que começa com a letra G");
            lista.Add(p);
            lista.Add(new NovaPergunta("Aplicativo de assistir filmes?","Netflix","O mais assistido do momento"));
            return lista;
        }
    }
}
