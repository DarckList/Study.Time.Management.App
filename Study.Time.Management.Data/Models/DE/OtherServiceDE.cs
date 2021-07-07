using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    [Table("OtherServices")]
    public class OtherServiceDE : BaseEntity
    {
        [Key]
        public int Id { get; set; }


    }
}
