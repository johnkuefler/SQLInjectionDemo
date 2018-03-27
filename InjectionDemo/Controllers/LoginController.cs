using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InjectionDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Database=Injection;Integrated Security=true;");

            string qry = "select * from Login where Email='" + email + "'and Password='" + password + "' ";

            var adpt = new SqlDataAdapter(qry, con);

            var dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                return View("LoggedIn");
            }
            else
            {
                ViewBag.Error = "Invalid login";
                return View();
            }
        }
    }
}