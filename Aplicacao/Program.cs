using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Data;
using Infra.Repositorio;
using Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init");

            RepositorioCompra repositorio = new RepositorioCompra();
            List<Compra> compras = repositorio.GetAll();

            var SoComprasDoProduto1 =
                from c in compras where c.CompraID == 1 select c.CompraID;
            
            foreach (Compra c in compras)
            {
                Console.WriteLine("CompraId: {0}, Data: {1}", c.CompraID, c.DataCompra.ToShortDateString());
                foreach(Item i in c.Itens)                
                    Console.WriteLine("- Produto:{0}, Quantidade:{1}, Valor Unitario: {2}, Valor Total: {3}", i.Produto.Descricao, i.Quantidade, i.ValorUnitario, i.Quantidade * i.ValorUnitario);
                Console.WriteLine("Valor Total da Compra: {0}", c.Itens.Sum(v=> v.Quantidade * v.ValorUnitario));

                Console.WriteLine("\n");
            }

            

            Console.ReadKey();
        }
    }
}
