using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Entrega
{
    public class Entrega_Dados
    {
        public int id_entrega { get; set; }
        public int id_venda { get; set; }
        public int id_veiculo { get; set; }
        public DateTime Data_Entrega { get; set; }
	    public String situacao_Entrega { get; set; }
    }
}
