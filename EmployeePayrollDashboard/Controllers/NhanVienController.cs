using EmployeePayrollDashboard.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeePayrollDashboard.Controllers
{
    namespace EmployeePayrollDashboard.Controllers
    {
        public class NhanVienController : Controller
        {
            private NhanVienDAL dal = new NhanVienDAL();
            public ActionResult Index()
            {
                List<NhanVien> danhSach = dal.GetAllNhanVien();
                return View(danhSach);
            }
        }
    }
}
