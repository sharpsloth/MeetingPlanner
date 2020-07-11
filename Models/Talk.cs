using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Talk
    {
        public int ID { get; set; }
        public int PlannerID { get; set; }
        public string Speaker { get; set; }
        public string Topic { get; set; }
        public Planner Planner { get; set; }
    }
}
