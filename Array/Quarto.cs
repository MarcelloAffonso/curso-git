using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Quarto
    {
        public Pessoa Locador { get; set; }

        public Quarto(Pessoa locador)
        {
            Locador = locador;
        }

        public override string ToString()
        {
            return Locador.ToString();
        }
    }
}
