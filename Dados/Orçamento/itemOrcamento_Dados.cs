using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Orçamento
{
    public class itemOrcamento_Dados
    {
        public int Id_Item { get; set; }
        public int Id_Produto { get; set; }
        public int quant_vendida { get; set; }
        public Double prec_Unitario { get; set; }
    }
}
