using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Orçamento
{
    public class orcamento_Dados
    {
        public int id_orcamento { get; set; }
        public int fun_id { get; set; }
        public int id_ItemOrcamento { get; set; }
        public double valor_orcamento { get; set; }
        public DateTime data_orcamento  { get; set; }
    }
}
