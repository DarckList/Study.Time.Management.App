namespace Study.Time.Management.Query.Shared
{
    public class PageOptions<TOrder, TFilter>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 50;
        public TOrder Orders { get; set; }
        public TFilter Filters { get; set; }
    }
}
