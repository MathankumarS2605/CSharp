using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            List<Employee> employees = EmpDbRepository.GetEmpList();
            if (employees != null && employees.Count  > 0)
            {
                return View("EmployeeList",employees);
            }
            return View("Index1");
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            if(id <= 0)
            {
                return RedirectToAction("Index");
            }
            Employee employee=EmpDbRepository.GetEmptyById(id);
            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            Employee employee=new Employee();   
            return View(employee);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Employee employee)
        {
            try
            {
                if(ModelState.IsValid) {
                    EmpDbRepository.AddNewEmp(employee);
                }
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            
            if(id <=0)
            {
                return RedirectToAction("Index");
            }
            Employee employee = EmpDbRepository.GetEmptyById(id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.UpdateEmp(emp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id <= 0)
            {
                return RedirectToAction("Index");
            }
            Employee emp=EmpDbRepository.GetEmptyById(id);
            return View(emp);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
