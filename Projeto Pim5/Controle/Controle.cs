using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pim5
{
    internal class Controle
    {
        private string mensagem;
        private bool tem;

        public Controle()
        {
        }

        public string Mensagem { get => mensagem; }
        public bool Tem { get => tem; }

        // Método para realizar alguma operação específica, como validação de entrada ou processamento de dados
        public void RealizarOperacao(string parametro1, string parametro2)
        {
            // Aqui você pode implementar a lógica de negócios necessária para o seu aplicativo
            // Por exemplo, validar entrada de dados, processar informações, etc.

            // Após realizar a operação desejada, atualize a propriedade 'mensagem' com alguma mensagem relevante
            mensagem = "Operação realizada com sucesso!";
            tem = true; // Define 'tem' como true se a operação foi bem-sucedida
        }

        // Método para limpar a mensagem e redefinir o estado
        public void LimparMensagem()
        {
            mensagem = string.Empty;
            tem = false;
        }
    }
}
