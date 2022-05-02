using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Venda_DadosGrid
    {
        public string id_venda{get;set;} 
        public string fun_id {get;set;}
        public string cli_id { get; set; }
        public string id_itemVenda  {get;set;}
        public string id_formaPag  {get;set;}
        public string valor_venda {get;set;}
        public string data_venda {get;set;}
        public string valor_recebido{get;set;}
        public string troco {get;set;}
        public string entrega {get;set;}
    }
}
