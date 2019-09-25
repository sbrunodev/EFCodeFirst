using Dominio.Interfaces;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private EscolaContext _context = new EscolaContext();
        private DbSet<T> tabela = null;

        public Repository()
        {
            _context = new EscolaContext();
            tabela = _context.Set<T>();
        }

        public T Get(int id)
        {
            return tabela.Find(id);
        }

        public IList<T> GetAll()
        {
            return tabela.ToList();
        }

        public void Insert(T obj)
        {
            tabela.Add(obj);
        }

        public void Remove(int id)
        {
            T existing = tabela.Find(id);
            tabela.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            tabela.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
