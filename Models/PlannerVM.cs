using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class PlannerVM
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string Conducting { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingSong { get; set; }
        public string IntermediateMusic { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public ICollection<Talk> Talks { get; set; }
    }
}
