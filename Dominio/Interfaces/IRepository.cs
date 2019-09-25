using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepository<T>
    {
        void Save();

        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
