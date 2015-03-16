namespace Infra.Data
{
    using Domain.Entities;
    using Infra.Data.EntityConfig;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class Context : DbContext
    {
        public Context():base("MyDbTeste"){}

        public IDbSet<Person> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
