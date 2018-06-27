using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateApplication.Models.Views
{
    public class CandidateView
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<long> Mobile { get; set; }
        public string CallbackDetail { get; set; }
        public string CreateOn { get; set; }
        public string UpdateOn { get; set; }
        public Nullable<long> Pin { get; set; }
        public Nullable<bool> Active { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string OutcomeID { get; set; }
        public string SuboucomeID { get; set; }
        public string OutcomeDescription { get; set; }
        public string SuboutcomeDescription { get; set; }
        public List<OutcomeView> OutList{ get; set; }
}
}