using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class ReferenceDetail
    {
        public int Id { get; set; }
        public string? ReferenceName { get; set; }
        public string? Address { get; set; }
        public string? TelephoneNumber { get; set; }
        public int? ApplicantId { get; set; }

        public virtual ApplicationDetail? Applicant { get; set; }
    }
}
