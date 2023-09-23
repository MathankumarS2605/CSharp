﻿using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {

            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            if (list != null && list.Count > 0)
            {
                return View("AuthorList", list.Values.ToList());
            }
            return View();
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author author=AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            Author author = new Author();
            return View(author);
        }
        public ActionResult SavedAuthor(Author author)
        {
            AuthorRepository.SaveToFile(author);
            return View();
        }
        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author author)
        {
            try
            {
                AuthorRepository.SaveToFile(author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }

            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Author author)
        {
            try
            {
               AuthorRepository.UpdateAuthorToFile(author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if (author != null)
            {
                return View(author);
            }

            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Author author)
        {
            try
            {
                AuthorRepository.DeleteAuthor(author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
