using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    public class RollDE
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public ICollection<UserDE> Users { get; set; }

    }
}
