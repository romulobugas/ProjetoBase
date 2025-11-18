using System.Collections.Generic;
using ProjetoBase.Enumeradores;

namespace ProjetoBase.Ferramentas
{
    public static class AutorizacaoAcaoManager
    {
        public static List<AutorizacaoAcao> lista = new List<AutorizacaoAcao>()
        {
            new AutorizacaoAcao(EnumAutorizacaoAcao.GERAR_CNM, "Registro de imovel -> Gerar CNM"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.ABERTURA_MATRICULA, "Registro de imovel -> Abertura de Matricula"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.DELETAR_CARTAO_AUTOGRAFO, "Deletar cartão de autografo"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.CONVERTER_DOI, "Converter DOI Para DOI Web"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.ALTERAR_GERACAO_PRENOTACAO_AUTOMATICA, "Alterar geração automatica de prenotação"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.ADICIONAR_PARTE_MANUALMENTE_RTD_RPJ, "Adicionar parte manualmente em RTD/RPJ"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.VER_ALERTA_PAGAMENTOS, "Receber alerta de pagamentos"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.GERAR_TEXTO_PRENOTACOES_SUBSISTENTES, "Gerar texto de prenotações subsistentes"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.SOMENTE_VISUALIZAR_CONTAS_A_RECEBER, "Somente visualizar menu de contas a receber"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.SOMENTE_VISUALIZAR_COMPENSACAO_CONTAS, "Somente visualizar compensação de contas"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.LIBERAR_EDICAO_MODELO_DOCUMENTO, "Liberar edição de texto nos modelos de documento (Notas/RI)"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.ENCERRAR_MATRICULA, "Encerrar matricula (Registro de Imovel)"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.CADASTRAR_PESSOA_SEM_CPF, "Cadastrar pessoa sem cpf (000.000.000-00)"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.CADASTRAR_PESSOA_SEM_CNPJ, "Cadastrar pessoa sem cnpj (00.000.000/0000-00)"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.CADASTRAR_PESSOA_SEM_ENDERECO, "Cadastrar pessoa sem endereço"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.EMITIR_NFE, "Emitir NFE"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.SALVAR_REGISTRO_CIVIL, "Realizar alterações em registro civil já finalizado."),
            new AutorizacaoAcao(EnumAutorizacaoAcao.SANGRIA_DE_CAIXA, "Sangria de Caixa"),
            new AutorizacaoAcao(EnumAutorizacaoAcao.PUBLICAR_EDITAL_COM_DATA_ANTERIOR, "Publicar edital de protesto com data anteior ao dia atual"),
        };
    }
}
