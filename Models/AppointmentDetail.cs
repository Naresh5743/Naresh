using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class AppointmentDetail
    {
        public int MonthId { get; set; }
        public string? MonthName { get; set; }
        public string? AvailableDays { get; set; }
        public string? TimeSlots { get; set; }
        public int? ApplicantId { get; set; }

        public virtual ApplicationDetail? Applicant { get; set; }
    }
}
