using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Venda_Dados
    {
        public int id_venda{get;set;} 
        public int fun_id {get;set;}
        public int cli_id { get; set; }
        public int id_itemVenda  {get;set;}
        public int id_formaPag  {get;set;}
        public double valor_venda {get;set;}
        public DateTime data_venda {get;set;}
        public double valor_recebido{get;set;}
        public double troco {get;set;}
        public String entrega {get;set;}
    }
}
