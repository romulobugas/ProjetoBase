using System;

namespace ProjetoBase.DataBase.Dominio.Funcionario
{
    public class CadastroUsuarioModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string NomeCompleto { get; set; }
        public bool Administrador { get; set; }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Login))
                throw new Exception("O login é obrigatório.");

            if (string.IsNullOrWhiteSpace(Senha))
                throw new Exception("A senha é obrigatória.");

            if (Senha != ConfirmarSenha)
                throw new Exception("As senhas não conferem.");

            if (string.IsNullOrWhiteSpace(NomeCompleto))
                throw new Exception("O nome completo é obrigatório.");
        }
    }
}
