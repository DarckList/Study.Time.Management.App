using MediatR;
using Study.Time.Management.Domain.Contractrs;
using System.Threading;
using System.Threading.Tasks;
using Categories = Study.Time.Management.Domain.Entities.Category;

namespace Study.Time.Management.Commands.Category.Create
{
    class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<int> Handle(CreateCategoryCommand command, CancellationToken cancellationToken)
        {
            var category = new Categories(command.Title);
            var categoryId = await _categoryRepository.Create(category);
            return categoryId;
        }
    }
}
