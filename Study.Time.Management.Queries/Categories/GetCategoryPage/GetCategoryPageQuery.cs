using MediatR;
using Study.Time.Management.Queries.FilterOptions;
using Study.Time.Management.Queries.OrderOptions;
using System.Collections.Generic;

namespace Study.Time.Management.Queries.Categories.GetCategoryPage
{

    public record GetCategoryPageQuery(
        int Page, 
        int PageSize, 
        CategoryOrderOption Order, 
        CategoryFilterOption Filter) : IRequest<IEnumerable<CategoryDto>> { }

}
