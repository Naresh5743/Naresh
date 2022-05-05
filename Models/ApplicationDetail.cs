using System;
using System.Collections.Generic;

namespace EPassport.Models
{
    public partial class ApplicationDetail
    {
        public ApplicationDetail()
        {
            AddressDetails = new HashSet<AddressDetail>();
            AppointmentDetails = new HashSet<AppointmentDetail>();
            FamilyDetails = new HashSet<FamilyDetail>();
            PassportOffices = new HashSet<PassportOffice>();
            ReferenceDetails = new HashSet<ReferenceDetail>();
            SupportingDocumentDetails = new HashSet<SupportingDocumentDetail>();
        }

        public int ApplicantId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Pan { get; set; }
        public string? EmploymentType { get; set; }
        public string? EducationalQualification { get; set; }
        public string? LoginId { get; set; }

        public virtual RegistrationDetail? Login { get; set; }
        public virtual ICollection<AddressDetail> AddressDetails { get; set; }
        public virtual ICollection<AppointmentDetail> AppointmentDetails { get; set; }
        public virtual ICollection<FamilyDetail> FamilyDetails { get; set; }
        public virtual ICollection<PassportOffice> PassportOffices { get; set; }
        public virtual ICollection<ReferenceDetail> ReferenceDetails { get; set; }
        public virtual ICollection<SupportingDocumentDetail> SupportingDocumentDetails { get; set; }
    }
}
