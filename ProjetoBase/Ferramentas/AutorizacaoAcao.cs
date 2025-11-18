using ProjetoBase.DataBase.Dominio.Interface;
using System;
using ProjetoBase.Enumeradores;

namespace ProjetoBase.Ferramentas
{
    public class AutorizacaoAcao : Entidade
    {
        public AutorizacaoAcao(EnumAutorizacaoAcao codigo, String nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }
        public EnumAutorizacaoAcao codigo;
        public String nome;

        public string Codigo
        {
            get
            {
                return Convert.ToInt32(codigo).ToString();
            }
        }

        public string Descricao
        {
            get
            {
                return nome;
            }
        }

        public Entidade Proprio
        {
            get
            {
                return this;
            }
        }
    }
}
