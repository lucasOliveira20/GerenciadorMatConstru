using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Produto_Dados
    {
         public int id_produto { get; set; }
         public int id_setor { get; set; }
         public int id_fabricante { get; set; }
         public Double cod_barra { get; set; }
         public String descricao { get; set; }
         public String Marca { get; set; }
         public String unidade_med { get; set; }
         public Double preco_compra { get; set; }
         public Double preco_venda { get; set; }
         public Double margem_lucro { get; set; }

    }
}
