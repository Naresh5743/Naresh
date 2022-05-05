using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class RegistrationDetail
    {
        public RegistrationDetail()
        {
            ApplicationDetails = new HashSet<ApplicationDetail>();
        }

        public string LoginId { get; set; } = null!;
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? EmailId { get; set; }
        public string? PhoneNo { get; set; }

        public virtual ICollection<ApplicationDetail> ApplicationDetails { get; set; }
    }
}
