using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinalEMDAAdvanced.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }

        //[Required] public string ResourceId { get; set; }

        public string EventColor { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [DataType(DataType.DateTime)]
        //[ValidateEndDate(ErrorMessage = "Start date must be before End date")]
        public DateTime End { get; set; }
        public string Title { get; set; }
        public bool IsFullDay { get; set; }
        public int Days { get; set; }
        public int Weeks { get; set; }
        public Staff Staff { get; set; }
    }
}
