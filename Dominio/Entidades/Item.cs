using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Item
    {
        public int ItemID { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int CompraId { get; set; }
        public Compra Compra { get; set; }
    }
}
