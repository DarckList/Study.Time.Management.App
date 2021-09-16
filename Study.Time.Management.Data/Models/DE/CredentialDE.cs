using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    public class CredentialDE
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int UserId { get; set; }
        public UserDE User { get; set; }
    }
}
