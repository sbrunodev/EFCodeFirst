using Dominio.Entidades;
using MySql.Data.Entity;
using System.Data.Entity;

namespace Infra.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("name=ConexaoMySQL")
        {
            // DropCreateDatabaseIfModelChanges
            Database.SetInitializer<EscolaContext>(new CreateDatabaseIfNotExists<EscolaContext>());
            Database.SetInitializer<EscolaContext>(null);
        }
        
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}