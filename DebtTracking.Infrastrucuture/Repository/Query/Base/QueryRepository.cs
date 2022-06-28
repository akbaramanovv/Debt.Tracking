using DebtTracking.Core.Repositories.Query.Base;
using DebtTracking.Infrastrucuture.Data;
using Microsoft.Extensions.Configuration;

namespace DebtTracking.Infrastrucuture.Repository.Query.Base
{
    public class QueryRepository<T> : DbConnector, IQueryRepository<T> where T : class
    {
        public QueryRepository(IConfiguration configuration)
            : base(configuration)
        {

        }
    }
}
