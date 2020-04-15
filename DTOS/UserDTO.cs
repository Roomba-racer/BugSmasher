using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugSmasher.DTOS
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAdress { get; set; }
        public byte[] UserAvatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public int UserTypeId { get; set; }
        public bool canLead { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
