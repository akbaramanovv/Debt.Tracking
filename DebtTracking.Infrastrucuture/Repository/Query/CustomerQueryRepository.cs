using Dapper;
using DebtTracking.Core.Entities;
using DebtTracking.Core.Repositories.Query;
using DebtTracking.Infrastrucuture.Repository.Query.Base;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DebtTracking.Infrastrucuture.Repository.Query
{
    public class CustomerQueryRepository : QueryRepository<Core.Entities.Customer>, ICustomerQueryRepository
    {
        public CustomerQueryRepository(IConfiguration configuration)
            : base(configuration)
        {

        }

        public async Task<IReadOnlyList<Core.Entities.Customer>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM CUSTOMERS";

                using var connection = CreateConnection();
                return (await connection.QueryAsync<Customer>(query)).ToList();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Core.Entities.Customer> GetByIdAsync(long id)
        {
            try
            {
                var query = "SELECT * FROM CUSTOMERS WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int64);

                using var connection = CreateConnection();
                return (await connection.QueryFirstOrDefaultAsync<Core.Entities.Customer>(query, parameters));
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Core.Entities.Customer> GetCustomerByEmail(string email)
        {
            try
            {
                var query = "SELECT * FROM CUSTOMERS WHERE Email = @email";
                var parameters = new DynamicParameters();
                parameters.Add("Email", email, DbType.String);

                using var connection = CreateConnection();
                return (await connection.QueryFirstOrDefaultAsync<Core.Entities.Customer>(query, parameters));
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }
    }
}
