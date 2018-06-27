using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandidateApplication.Models.Views
{
    public class OutcomeView
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public SelectList Suboutcomes { get; set; }
        public List<SubOutcome> Suboutcomelist { get; set; }
    }
}