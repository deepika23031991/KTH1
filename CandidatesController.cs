using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CandidateApplication.Models;
using CandidateApplication.Models.Views;

namespace CandidateApplication.Controllers
{
    public class CandidatesController : Controller
    {
        private CandidateContext db = new CandidateContext();

        // GET: Candidates
        public ActionResult Index()
        {
            return View(db.Candidates.ToList());
        }

        // GET: Candidates/Create
        public ActionResult Create()
        {
            var stateList = db.States.ToList();

            ViewBag.StatesList = new SelectList(stateList.ToList(), "ID", "StateName");
            CandidateView cv = new CandidateView();
            cv.OutList = (from a in db.Outcomes.Include("SubOutcomes")
                         select new OutcomeView {
                             ID=a.ID,
                             Name=a.Name,
                             Suboutcomelist= a.SubOutcomes.ToList()
                         }
                         ).ToList();
            return View(cv);          
        }

        // POST: Candidates/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,Mobile,CallbackDetail,CreateOn,UpdateOn,Pin,Active,CityCode,StateCode")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                db.Candidates.Add(candidate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidate);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        #region 

        // GET: Get State
        public JsonResult State()
        {
            List<State> state = new List<State>();
            state = db.States.ToList();
            return Json(state, JsonRequestBehavior.AllowGet);
        }

        // Get City
        public JsonResult City(string stateId)
        {
            List<City> city = new List<City>();
            city = (from a in db.Cities.Where(x=>x.StateCode==stateId)
                    select a).ToList() ;
            return Json(city, JsonRequestBehavior.AllowGet);
        }

        // Get Outcome
        public JsonResult Outcome()
        {
            List<Outcome> outcomes = new List<Outcome>();
            outcomes = db.Outcomes.ToList();
            return Json(outcomes, JsonRequestBehavior.AllowGet);
        }
        // Get Sub Outcome
        public JsonResult Suboutcome(string Selectedoutcome)
        {
            var suboutcome = db.SubOutcomes.ToList();
            
            return Json(suboutcome, JsonRequestBehavior.AllowGet);
        }

        #endregion



    }
}
