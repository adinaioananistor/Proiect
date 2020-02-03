using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageDeliveryApp.Controllers
{
    public class UserController : Controller
    {
        private Repository.UserRepository userRepository = new Repository.UserRepository();
        

        // GET: User
        public ActionResult Index()
        {
            //incarcam lista cu utilizatori
            List<Models.UsersModel> users = userRepository.GetAllUsers();
            return View("Index",users);
        }

        // GET: User/Details/5
        public ActionResult Details(Guid id)
        {
            //incarcam modelul pe baza id-ului
            Models.UsersModel userModel = userRepository.GetUserByID(id);
            return View("User Detalis", userModel);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View("CreateUser");
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.UsersModel usermodel = new Models.UsersModel();
                UpdateModel(usermodel);
                userRepository.InsertUser(usermodel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateUser");
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(Guid id)
        {
            Models.UsersModel userModel = userRepository.GetUserByID(id);
            return View("EditUser",userModel);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Models.UsersModel userModel = new Models.UsersModel();                UpdateModel(userModel);                userRepository.UpdateUser(userModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Edit User");
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(Guid id)
            
        {
            Models.UsersModel userModel = userRepository.GetUserByID(id);//incarcam datele in model din db
            return View("DeleteUser",userModel);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                //apelam repository care sterge datele
                userRepository.DeleteUser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Delete User");
            }
        }
    }
}
