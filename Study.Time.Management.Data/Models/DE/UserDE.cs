using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models
{
    [Table("Users")]
    public class UserDE : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CredentialId { get; set; }
        public int RoleId { get; set; }
        public int? ClientId { get; set; }
        //public byte[] Ava { get; set; }
    }
}
