using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class SupportingDocumentDetail
    {
        public int Id { get; set; }
        public byte[]? Document1 { get; set; }
        public byte[]? Document2 { get; set; }
        public int? ApplicantId { get; set; }

        public virtual ApplicationDetail? Applicant { get; set; }
    }
}
