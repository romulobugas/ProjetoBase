using System;
using System.Collections.Generic;
using ProjetoBase.Enumeradores;

namespace ProjetoBase.Ferramentas
{
    public class MenuNode
    {
        public string Texto { get; }
        public EnumNivelDeAcesso[] Niveis { get; }
        public EventHandler Click { get; }
        public List<MenuNode> Filhos { get; } = new List<MenuNode>();

        public MenuNode(string texto,
                        EnumNivelDeAcesso[] niveis,
                        EventHandler click = null)
        {
            Texto = texto;
            Niveis = niveis;
            Click = click;
        }
    }
}
