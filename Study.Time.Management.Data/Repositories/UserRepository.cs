using Dapper;
using Study.Time.Management.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Study.Time.Management.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private IDbConnection _db;
        public UserRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> CreateAsync(UserDE entity)
        {
            var query = "INSERT INTO Users(y) V"
        }

        public Task<int> DeleteAsync(UserDE entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDE>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM Users";
                using var connection = CreateConnection();
                return (await connection.QueryAsync<UserDE>(query).ToList());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<UserDE> GetByIdAsync(int id)
        {
            var query = "SELECT * FROM Users where Id = @id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);

            try
            {
                using var connection = CreateConnection();
                return (await connection.QueryFirstOrDefaultAsync<UserDE>(query, parameters));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public Task<int> UpdateAsync(UserDE entity)
        {
            throw new NotImplementedException();
        }
    }
}
