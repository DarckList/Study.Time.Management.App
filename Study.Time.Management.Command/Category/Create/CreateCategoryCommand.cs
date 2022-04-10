using MediatR;

namespace Study.Time.Management.Commands.Category.Create
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string Title { get; set; }
    }
}
