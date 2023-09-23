using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEFApp.Models;
using NuGet.Protocol.Core.Types;

namespace MVCEFApp.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> list = RepositoryPatient.GetPatients();
            if(list  != null && list.Count > 0)
            {
                return View(list);
            }    
            return RedirectToAction("Create");
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Patient patient)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(patient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            if(id <= 0)
            {
                return RedirectToAction(nameof(Index)); 
            }
            Patient patient=RepositoryPatient.GetPatientsById(id);  
            return View(patient);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Patient patient)
        {
            try
            {
                if(ModelState.IsValid) {
                    RepositoryPatient.ModifyPatient(patient);   
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id <= 0)
            {
                return View("Index");
            }
            Patient patient= RepositoryPatient.GetPatientsById(id); 
            return View(patient);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                RepositoryPatient.RemovePatient(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
