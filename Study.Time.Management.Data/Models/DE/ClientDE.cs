using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    public class ClientDE: BaseEntity
    {
        public string Title { get; set; }
        public int? OtherServiceId { get; set; }

        public ICollection<UserDE> Users { get; set; }
    }
}
