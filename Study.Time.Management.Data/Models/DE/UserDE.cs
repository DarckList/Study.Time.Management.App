using Study.Time.Management.Data.Models.DE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models
{
    public class UserDE
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CredentialId { get; set; }
        public CredentialDE Credential { get; set; }

        public int RoleId { get; set; }
        public RollDE Role { get; set; }

        public int? ClientId { get; set; }
        public ClientDE Client { get; set; }

        //public byte[] Ava { get; set; }
    }
}
