using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPattern
{
    internal class Regra3Bloqueio : IBloquearConta
    {
        public bool analiseBloqueio(Conta conta, TransacaoBancaria transacaoBancaria)
        {
            if (transacaoBancaria.Valor > 30000)
            {
                return  true;
            }
            else
            {
                return false;
            }
        }
    }
}
