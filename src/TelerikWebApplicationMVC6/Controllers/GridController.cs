using System;
using System.Linq;
using Kendo.Mvc.UI;
using TelerikWebApplicationMVC6.Models;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace TelerikWebApplicationMVC6.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult Orders_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = Enumerable.Range(0, 50).Select(i => new OrderViewModel
            {
                OrderID = i,
                Freight = i * 10,
                OrderDate = DateTime.Now.AddDays(i),
                ShipName = "ShipName " + i,
                ShipCity = "ShipCity " + i
            });

            return Json(result.ToDataSourceResult(request));
        }
    }
}
