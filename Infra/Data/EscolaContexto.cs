using Dominio.Entidades;
using System.Data.Entity;

namespace Infra.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base()
        {

        }
        
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}