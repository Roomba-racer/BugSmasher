using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugSmasher.DTOS
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectStatus { get; set; }
        public int ProjectStatusId { get; set; }
        public string Client { get; set; }
        public int ClientId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Finished { get; set; }
    }
}

