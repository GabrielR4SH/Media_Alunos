using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Medias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Media geral dos alunos!!!";

            Console.WriteLine("Quantos alunos vai cadastrar ?");

            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #:" + (i+1) + " Nome..:");
                
                string nome = Console.ReadLine();
                Console.Write("Aluno #:" + (i + 1) + " Provas..:");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].inserirNotas();


            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media);

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Media geral dos alunos: " + resultadoFinal);

            Console.ReadKey();

        }
    }
}
