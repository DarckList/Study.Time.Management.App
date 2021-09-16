using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Study.Time.Management.Data;
using Study.Time.Management.Data.Models.DE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.Time.Management.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        
        private readonly ILogger<CategoryController> _logger;
        private Categories _category;

        public CategoryController(ILogger<CategoryController> logger, Categories categories)
        {
            _logger = logger;
            _category = categories;
        }

        [HttpGet]
        public IEnumerable<Clients> Get()
        {
            var categorys = _category.GetCategorys();
            _logger.LogInformation(categorys.ToString());
            
            return categorys;
        }
    }

   
}
