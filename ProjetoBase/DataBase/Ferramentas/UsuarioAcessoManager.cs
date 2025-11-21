using NHibernate;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.Enumeradores;
using System;

namespace ProjetoBase.DataBase.Ferramentas
{
    public class UsuarioAcessoManager
    {
        private ISession Sessao => Repositorios.Usuario.getSessao(false);

        // ==============================
        // LOGIN
        // ==============================
        public Usuario EfetuarLogin(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                throw new Exception("Login e senha são obrigatórios.");

            Usuario usuario = BuscarUsuarioPorLogin(login);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            if (usuario.Senha != senha)
                throw new Exception("Senha incorreta.");

            if (usuario.Funcionario?.Inativo == true)
                throw new Exception("Usuário inativo.");

            return usuario;
        }

        // ==============================
        // BUSCAR POR LOGIN
        // ==============================
        public Usuario BuscarUsuarioPorLogin(string login)
        {
            return Sessao.QueryOver<Usuario>()
                         .Where(u => u.Login == login)
                         .SingleOrDefault();
        }

        // ==============================
        // CADASTRAR USUÁRIO
        // ==============================
        public EnumResultadoQuery CriarUsuario(Usuario novoUsuario)
        {
            if (novoUsuario == null)
                return EnumResultadoQuery.ERRO_GENERICO;

            if (string.IsNullOrWhiteSpace(novoUsuario.Login))
                throw new Exception("Login é obrigatório.");

            if (BuscarUsuarioPorLogin(novoUsuario.Login) != null)
                throw new Exception("Já existe um usuário com esse login.");

            return Repositorios.Usuario.Salvar(novoUsuario);
        }

        // ==============================
        // EDITAR USUÁRIO
        // ==============================
        public EnumResultadoQuery AtualizarUsuario(Usuario usuario)
        {
            if (usuario == null || usuario.Id == 0)
                throw new Exception("Usuário inválido.");

            return Repositorios.Usuario.Salvar(usuario);
        }

        // ==============================
        // DESATIVAR
        // ==============================
        public EnumResultadoQuery DesativarUsuario(int usuarioId)
        {
            Usuario usuario = Repositorios.Usuario.ProcurarPorID(usuarioId);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            if (usuario.Funcionario == null)
                throw new Exception("Usuário não possui funcionário vinculado.");

            usuario.Funcionario.Inativo = true;

            return Repositorios.Usuario.Salvar(usuario);
        }

        // ==============================
        // EXCLUIR DEFINITIVAMENTE
        // ==============================
        public EnumResultadoQuery ExcluirUsuario(int usuarioId)
        {
            Usuario usuario = Repositorios.Usuario.ProcurarPorID(usuarioId);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            return Repositorios.Usuario.Excluir(usuario);
        }

        // ==============================
        // ALTERAR SENHA
        // ==============================
        public EnumResultadoQuery AlterarSenha(int usuarioId, string novaSenha)
        {
            if (string.IsNullOrWhiteSpace(novaSenha))
                throw new Exception("A nova senha não pode ser vazia.");

            Usuario usuario = Repositorios.Usuario.ProcurarPorID(usuarioId);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            usuario.Senha = novaSenha;
            usuario.ResetarSenha = false;

            return Repositorios.Usuario.Salvar(usuario);
        }
    }
}
