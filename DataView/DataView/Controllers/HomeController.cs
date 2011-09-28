using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Exchange Grid Data";

            return View();
        }
        
        public ActionResult ExchangeGrid(string sidx, string sord, int page, int rows)
        {
            int totalPages = 1;
            int pageSize = rows;
            int totalRecords = 3;
            
                var jsonData = new
                {
                    total = totalPages,
                    page = page,
                    totalRecords = totalRecords,
                    rows = new[]
                                              {
                                                  new {id = 1, cell = new[] {"1", "LN", "London Stock Exchange"}},
                                                  new {id = 2, cell = new[] {"2", "EOE", "Liffe London"}},
                                                  new {id = 3, cell = new[] {"3", "EUX", "Deutsche Boersche"}}
                                              }
                };
                return Json(jsonData, JsonRequestBehavior.AllowGet);
           
        }

        public ActionResult AddressGrid(int AddressGrid, string sidx, string sord, int page, int rows)
        {
            int totalPages = 1;
            int pageSize = rows;
            int totalRecords = 3;

            if (AddressGrid.Equals(1))
            {
                var jsonData = new
                                   {
                                       total = totalPages,
                                       page = page,
                                       totalRecords = totalRecords,
                                       rows = new[]
                                                  {
                                                      new {id = 1, cell = new[] {"1", "229.173.101.1", "15001"}},
                                                      new {id = 2, cell = new[] {"2", "229.173.101.2", "15002"}},
                                                      new {id = 3, cell = new[] {"3", "229.173.101.3", "15004"}}
                                                  }
                                   };
                return Json(jsonData, JsonRequestBehavior.AllowGet);
            }
            else if (AddressGrid.Equals(2))
            {
                var jsonData = new
                {
                    total = totalPages,
                    page = page,
                    totalRecords = totalRecords,
                    rows = new[]
                                                  {
                                                      new {id = 1, cell = new[] {"1", "229.173.102.1", "15001"}},
                                                      new {id = 2, cell = new[] {"2", "229.173.102.2", "15002"}},
                                                      new {id = 3, cell = new[] {"3", "229.173.102.3", "15004"}}
                                                  }
                };
                return Json(jsonData, JsonRequestBehavior.AllowGet);

            }
            else
            {
                var jsonData = new
                {
                    total = totalPages,
                    page = page,
                    totalRecords = totalRecords,
                    rows = new[]
                                                  {
                                                      new {id = 1, cell = new[] {"1", "229.173.103.1", "15001"}},
                                                      new {id = 2, cell = new[] {"2", "229.173.103.2", "15002"}},
                                                      new {id = 3, cell = new[] {"3", "229.173.103.3", "15004"}}
                                                  }
                };
                return Json(jsonData, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult UsageGrid(string sidx, string sord, int page, int rows)
        {
            int totalPages = 1;
            int pageSize = rows;
            int totalRecords = 3;

            var jsonData = new
            {
                total = totalPages,
                page = page,
                totalRecords = totalRecords,
                rows = new[]
                                              {
                                                  new {id = 1, cell = new[] {"1", "LN", "London Stock Exchange"}},
                                                  new {id = 2, cell = new[] {"2", "EOE", "Liffe London"}},
                                                  new {id = 3, cell = new[] {"3", "EUX", "Deutsche Boersche"}}
                                              }
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }

        public ActionResult About()
        {
            return View();
        }

        public object jsonData { get; set; }
    }
}
