using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Estoque_Dados
    {
       public int id_estoque {get;set;}
       public int id_loc { get; set; }
       public int id_fornecedor { get; set; }
       public int id_produto{get;set;}      
       public int quant_disponivel  {get;set;}
       public DateTime dataADD { get; set; }
    }
}
