namespace Infra.Data.EntityConfig
{
    using System.Data.Entity;
    using System.Data.Entity.SqlServer;

    public class ContextConfiguration : DbConfiguration
    {
        public ContextConfiguration()
	    {
            SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
	    }
    }
}
