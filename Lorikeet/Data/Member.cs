//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorikeet.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Contacts = new HashSet<Contact>();
            this.DebitSystems = new HashSet<DebitSystem>();
            this.Diagnosis = new HashSet<Diagnosi>();
            this.Medications = new HashSet<Medication>();
            this.Pictures = new HashSet<Picture>();
            this.SignIns = new HashSet<SignIn>();
        }
    
        public int MemberID { get; set; }
        public Nullable<bool> Aboriginal { get; set; }
        public Nullable<bool> Agency { get; set; }
        public Nullable<bool> Archived { get; set; }
        public Nullable<bool> BirthdayCard { get; set; }
        public string Country { get; set; }
        public string CountryOfOrigin { get; set; }
        public Nullable<System.DateTime> DateAltered { get; set; }
        public Nullable<System.DateTime> DateJoined { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string MobileNumber { get; set; }
        public string PostCode { get; set; }
        public Nullable<bool> ReceiveByMail { get; set; }
        public Nullable<bool> ReceiveNewsletter { get; set; }
        public Nullable<bool> Sex { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public Nullable<bool> Studying { get; set; }
        public string Suburb { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        public Nullable<bool> Volunteering { get; set; }
        public Nullable<bool> Working { get; set; }
        public Nullable<bool> ReturnToSender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitSystem> DebitSystems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnosi> Diagnosis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medication> Medications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Picture> Pictures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SignIn> SignIns { get; set; }
    }
}
