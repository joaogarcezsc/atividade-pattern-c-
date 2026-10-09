using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPattern
{
    public class Regra4Bloqueio : IBloquearConta
    {
        public bool analiseBloqueio(Conta conta, TransacaoBancaria transacaoBancaria)
        {
            List<string> sudeste = new List<string> { "SP", "MG", "RJ", "ES" };

            if (sudeste.Contains(transacaoBancaria.AgenciaTransacao) && conta.Score < 200)
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
