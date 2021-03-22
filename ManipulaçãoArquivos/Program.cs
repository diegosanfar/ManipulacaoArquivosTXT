using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaçãoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  StreamWriter escritor = new StreamWriter("teste.txt");
            StreamWriter escritor = File.AppendText("teste.txt");
            escritor.WriteLine("Udemy");
            escritor.WriteLine("Teste de escrita");
            escritor.Close();
            */

            StreamReader leitor = new StreamReader("teste.txt");
            // string conteudo = leitor.ReadToEnd();
            // Console.WriteLine(leitor.ReadLine());

            List<string> linhas = new List<string>();
            string linha = "";
            while (linha != null)
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    linhas.Add(linha);
                }
            }

            leitor.Close();

           // Console.WriteLine(conteudo);
          // foreach(string nome in linhas)
          //  {
          //      Console.WriteLine(nome);
          // }

            Console.WriteLine("Arquivo gerado.");
            Console.ReadLine();
        }
    }
}
