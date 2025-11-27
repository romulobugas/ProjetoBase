using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetoBase.CustomControl;
using ProjetoBase.Enumeradores;

namespace ProjetoBase.Ferramentas
{
    public static class MenuBuilder
    {
        public static void Construir(MenuStrip strip,
                                     EnumNivelDeAcesso nivelUsuario,
                                     IEnumerable<MenuNode> raiz)
        {
            strip.Items.Clear();

            foreach (var node in raiz)
            {
                var item = CriarItem(node, nivelUsuario);
                if (item != null)
                    strip.Items.Add(item);
            }
        }

        private static ToolStripMenuItemCC CriarItem(MenuNode node,
                                                     EnumNivelDeAcesso nivelUsuario)
        {
            bool permitido = UsuarioTemAcesso(node.Niveis, nivelUsuario);

            // processa filhos recursivamente
            var filhosPermitidos = new List<ToolStripMenuItemCC>();
            foreach (var filho in node.Filhos)
            {
                var itemFilho = CriarItem(filho, nivelUsuario);
                if (itemFilho != null)
                    filhosPermitidos.Add(itemFilho);
            }

            // se não tem acesso e não sobrou nenhum filho visível, não cria nada
            if (!permitido && filhosPermitidos.Count == 0)
                return null;

            var item = new ToolStripMenuItemCC
            {
                Text = node.Texto,
                NiveisDeAcesso = node.Niveis
            };

            if (node.Click != null)
                item.Click += node.Click;

            if (filhosPermitidos.Count > 0)
                item.DropDownItems.AddRange(filhosPermitidos.ToArray());

            return item;
        }

        private static bool UsuarioTemAcesso(EnumNivelDeAcesso[] niveis,
                                             EnumNivelDeAcesso nivelUsuario)
        {
            if (nivelUsuario == EnumNivelDeAcesso.Administrador)
                return true;

            if (niveis == null || niveis.Length == 0)
                return true;

            return niveis.Contains(nivelUsuario);
        }
    }
}
