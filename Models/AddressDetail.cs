using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class AddressDetail
    {
        public int Id { get; set; }
        public string? HouseNo { get; set; }
        public string? StreetName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public int? Pincode { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? EmailId { get; set; }
        public int? ApplicantId { get; set; }

        public virtual ApplicationDetail? Applicant { get; set; }
    }
}
