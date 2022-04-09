using System.Collections.Generic;

namespace Study.Time.Management.Data.Models.DE
{
    public class ClientDE
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? OtherServiceId { get; set; }

        public ICollection<UserDE> Users { get; set; }
    }
}
