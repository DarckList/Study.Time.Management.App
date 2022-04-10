using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Study.Time.Management.API.Models.Category;
using Study.Time.Management.Commands.Category.Create;
using Study.Time.Management.Queries.Categories.GetCategoryPage;
using Study.Time.Management.Queries.FilterOptions;
using Study.Time.Management.Queries.OrderOptions;
using Study.Time.Management.Query.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Study.Time.Management.API.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ILogger<CategoryController> _logger;
        private readonly IMediator _mediator;

        public CategoryController(ILogger<CategoryController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("api/categorys")]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetPage([FromQuery] PageOptions<CategoryOrderOption, CategoryFilterOption> options)
        {
            var query = new GetCategoryPageQuery(options.Page, options.PageSize, options.Orders, options.Filters);
            var categorys = await _mediator.Send(query);
            _logger.LogInformation(categorys.ToString());

            return Ok(categorys);
        }

        [HttpPost("api/category")]
        public async Task<ActionResult<int>> Create([FromBody] NewCategory newCategory)
        {
            var command = new CreateCategoryCommand
            {
                Title = newCategory.Title
            };
            var categoryId = await _mediator.Send(command);
            return Ok(categoryId);
        } 
    }


}
