using Dapper;
using Study.Time.Management.Data.Models.DE;
using Study.Time.Management.Domain.Contractrs;
using Study.Time.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StmDbConnection _db;

        public CategoryRepository(StmDbConnection db)
        {
            _db = db;
        }

        public async Task<int> Create(Category category)
        {
            try
            {
                var newEntity = new CategoryDE
                {
                    Title = category.Title
                };

                var sqlQuery = @"insert into category
                                (""title"")
                                values (@Title)";

                var something = await _db.Connection.ExecuteAsync(sqlQuery, newEntity);
                return newEntity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> Get(int id)
        {
            var sql = @"select id, title 
                        from category
                        where id = @Id";

            var category = await _db.Connection.QueryAsync<Category>(sql, param: new { Id = id });
            return category.First();
        }

        public Task Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
