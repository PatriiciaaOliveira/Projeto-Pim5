using System;
using System.Collections.Generic;

internal class GerenciadorUsuarios
{
    // Armazenar os usuários em um dicionário para facilitar a busca
    private Dictionary<string, string> usuarios;

    public GerenciadorUsuarios()
    {
        // Inicializar o dicionário de usuários
        usuarios = new Dictionary<string, string>();
    }

    internal void AdicionarUsuario(string login, string senha, string senha1)
    {
        // Verificar se o login já existe
        if (usuarios.ContainsKey(login))
        {
            Console.WriteLine("Usuário já existe.");
            return;
        }

        // Verificar se as senhas coincidem
        if (senha != senha1)
        {
            Console.WriteLine("As senhas não coincidem.");
            return;
        }

        // Adicionar usuário ao dicionário
        usuarios.Add(login, senha);
        Console.WriteLine("Usuário adicionado com sucesso.");
    }

    internal void AdicionarUsuario(string login, string senha)
    {
        throw new NotImplementedException();
    }

    internal bool AutenticarUsuario(string login, string senha)
    {
        // Verificar se o usuário existe e a senha está correta
        if (usuarios.ContainsKey(login) && usuarios[login] == senha)
        {
            Console.WriteLine("Usuário autenticado com sucesso.");
            return true;
        }

        Console.WriteLine("Login ou senha incorretos.");
        return false;
    }
}
