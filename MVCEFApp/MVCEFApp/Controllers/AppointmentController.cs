using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MVCEFApp.Models;

namespace MVCEFApp.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: AppointmentController
        public ActionResult Index()
        {
            List<Appointment> list = RepositoryAppointment.GetAppiontments(); 
            if(list != null && list.Count > 0)
            {
                return View(list);
            }

            return RedirectToAction("Create");
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            if(id <= 0)
            {
                return RedirectToAction("Index");
            }
            Appointment appointment=RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
        
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Appointment appointment)
        {
            try
            {
                if(ModelState.IsValid) {
                    RepositoryAppointment.AddNewAppointment(appointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Appointment appointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.ModifyAppointment(appointment);   
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id <=0)
            {
                return RedirectToAction("Index");
            }
            Appointment appointment= RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                RepositoryAppointment.RemovePatient(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
