using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    [Table("AdditionalDatas")]
    public class AdditionalDataDE : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public byte[] Binaries { get; set; }
    }
}
