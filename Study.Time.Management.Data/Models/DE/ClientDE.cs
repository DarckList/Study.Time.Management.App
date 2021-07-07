﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    [Table("Clients")]
    public class ClientDE : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int? OtherServiceId { get; set; }
    }
}
