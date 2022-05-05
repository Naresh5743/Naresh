using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class PassportOffice
    {
        public int OfficeId { get; set; }
        public string? OfficeName { get; set; }
        public string? Jurisdiction { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public int? ApplicantId { get; set; }

        public virtual ApplicationDetail? Applicant { get; set; }
    }
}
