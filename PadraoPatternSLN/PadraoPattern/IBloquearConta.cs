using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPattern
{
     public interface IBloquearConta
    {
        bool analiseBloqueio(Conta conta, TransacaoBancaria transacaoBancaria);
    }
}
