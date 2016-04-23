using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.DAL;
using WebApplication.Models;
 


namespace WebApplication.Controllers
{
    
    [Authorize]
    public class AdminController : Controller
    {
        TouchContext Touch = new TouchContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            try
            {
                if (Touch.ContactUs.Count() == 0)
                {
                    return View();
                }
                else
                {
                    var Contact = Touch.ContactUs.FirstOrDefault();
                    return view(Contact);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(ContactUs Input)
        {
            try
            {
                if (Input.Id == 0)
                {
                    Touch.ContactUs.Add(Input);
                    Touch.SaveChanges();
                }
                else
                {
                    Touch.Entry(Input).State = EntityState.Modified;
                    Touch.SaveChanges();
                }
                return view(Input);
            }
            catch (Exception ex)
            {

                throw;
            }
            return Redirect("~/Admine/Index");
        }






    }
}