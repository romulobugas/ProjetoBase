using System;

namespace ProjetoBase.CustomControl
{
    public interface CustomControl
    {
        Boolean Valido();
        Boolean Obrigatorio { get; set; }
        String NomeDisplay { get; set; }
        Boolean SomenteLeitura{ get; set; }
        void Clear();
    }
}
