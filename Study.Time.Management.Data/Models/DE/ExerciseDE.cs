using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Time.Management.Data.Models.DE
{
    public class ExerciseDE
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
        public int CurcesId { get; set; }
        public int? AdditionalDataId { get; set; }
    }
}
