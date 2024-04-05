using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pim5
{
    internal static class Program
    {
        private static string arquivoCSV = "dados.csv";

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao sistema de cadastro!");

            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o e-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();

            // Verificar se o arquivo CSV já existe
            if (!File.Exists(arquivoCSV))
            {
                // Se não existir, criar o arquivo e adicionar o cabeçalho
                using (StreamWriter sw = File.CreateText(arquivoCSV))
                {
                    sw.WriteLine("Nome,Email,Senha");
                }
            }

            // Escrever os dados no arquivo CSV
            using (StreamWriter sw = File.AppendText(arquivoCSV))
            {
                sw.WriteLine($"{nome},{email},{senha}");
            }

            Console.WriteLine("Cadastro realizado com sucesso!");

            Console.WriteLine("Pressione qualquer tecla para sair...");
          
        }
    }
}


