using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPattern
{
    internal class Regra2Bloqueio : IBloquearConta
    {
        public bool analiseBloqueio(Conta conta, TransacaoBancaria transacaoBancaria)
        {
            if (conta.Score < 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
