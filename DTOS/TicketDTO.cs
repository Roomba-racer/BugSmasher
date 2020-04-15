using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugSmasher.DTOS
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TicketType { get; set; }
        public int TicketTypeId { get; set; }
        public string TicketPriority { get; set; }
        public int TicketPriorityId { get; set; }
        public string TicketStatus { get; set; }
        public int TicketStatusId { get; set; }
        public string Submitter { get; set; }
        public int SubmitterId { get; set; }
        public string AssignedTo { get; set; }
        public int AssignedToId { get; set; }
        public string Project { get; set; }
        public int ProjectId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
