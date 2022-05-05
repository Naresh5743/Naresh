using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class FamilyDetail
    {
        public int Id { get; set; }
        public string? FathersName { get; set; }
        public string? MothersName { get; set; }
        public int? ApplicantId { get; set; }

        public virtual ApplicationDetail? Applicant { get; set; }
    }
}
