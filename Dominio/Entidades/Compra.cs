using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Compra
    {
        public int CompraID { get; set; }
        public DateTime DataCompra { get; set; }

        public ICollection<Item> Itens { get; set; }
    }
}
