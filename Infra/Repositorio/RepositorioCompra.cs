using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioCompra : IRepositorio
    {
        private EscolaContext _context = new EscolaContext();
        private DbSet<Compra> tabela = null;

        public RepositorioCompra()
        {
            _context = new EscolaContext();
            tabela = _context.Set<Compra>();
        }

        public List<Compra> GetAll()
        {
            return _context.Compras
                .Include(c => c.Itens.Select(i => i.Produto))
                .ToList();
        }
    }
}
