using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    [Table("Exercises")]
    public class ExerciseDE : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
        public int CurcesId { get; set; }
        public int? AdditionalDataId { get; set; }
    }
}
