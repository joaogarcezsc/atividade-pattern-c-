using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPattern
{
    public class TransacaoBancaria
    {
        public int NumeroConta { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public string AgenciaTransacao { get; set; }
    }
}
