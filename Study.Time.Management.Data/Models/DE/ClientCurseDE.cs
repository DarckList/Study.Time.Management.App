using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    [Table("ClientCurses")]
    public class ClientCurseDE : BaseEntity
    {
        public int Id { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int ClientId { get; set; }
        public int CurseId { get; set; }
    }
}
