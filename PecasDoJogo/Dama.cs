using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace PecasDoJogo
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "D";
        }
    }
}
