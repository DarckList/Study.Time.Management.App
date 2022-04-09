using Dapper;
using MediatR;
using Study.Time.Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study.Time.Management.Queries.Categories.GetCategoryPage
{
    public class GetCategoryPageQueryHandler : IRequestHandler<GetCategoryPageQuery, IEnumerable<CategoryDto>>
    {
        private readonly StmDbConnection _db; 
        public GetCategoryPageQueryHandler(StmDbConnection db)
        {
            _db = db;
        }

        public async Task<IEnumerable<CategoryDto>> Handle(GetCategoryPageQuery request, CancellationToken cancellationToken)
        {


            var selectSqlQuery = new StringBuilder(@"select * from categories");
            if(request.Filter?.Id > 0)
            {
                selectSqlQuery.AppendLine("where id = @Id");
            }
            var categoryDto = await _db.Connection.QueryAsync<CategoryDto>(selectSqlQuery.ToString(), new { request.Filter?.Id });
            return categoryDto;
        }


    }
}
