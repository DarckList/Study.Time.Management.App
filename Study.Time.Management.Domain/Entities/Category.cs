using Ardalis.GuardClauses;

namespace Study.Time.Management.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; }

        public Category(string title)
        {
            Title = Guard.Against.NullOrEmpty(title, nameof(title));
        }

        private Category (int id, string title)
        {
            Id = id;
            Title = title;
        }

        public Category Restore(int id, string title)
        {
            return new Category(id, title);
        }
    }
}
