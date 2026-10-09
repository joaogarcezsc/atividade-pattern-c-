using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPattern
{
    internal class Regra1Bloqueio : IBloquearConta
    {
        public bool analiseBloqueio(Conta conta, TransacaoBancaria transacaoBancaria)
        {
            if (transacaoBancaria.AgenciaTransacao != conta.UFAgencia)
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
