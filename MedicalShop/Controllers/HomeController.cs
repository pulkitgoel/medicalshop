using MedicalShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalShop.Controllers
{
    public class HomeController : Controller
    {
        List<Medicine> list = null;

        public ActionResult Index()
        {
            
            GetData();
            return View(list);
        }

        public ActionResult Edit(string id)
        {
            Medicine medicine = null;
            if (!string.IsNullOrEmpty(id))
            {
                list = Session["list"] as List<Medicine>;
                medicine = list.Where(x => x.ID == Convert.ToInt32(id)).FirstOrDefault();
            }

            return View(medicine);
        }

        [HttpPost]
        public ActionResult Index(string MedicineName)
        {
            list = Session["list"] as List<Medicine>;
            var medicines = list.Where(x => x.Name.Contains(MedicineName));
            return View(medicines);
        }


        [HttpPost]
        public ActionResult Edit(Medicine MD)
        {
            list = Session["list"] as List<Medicine>;
            var medicine = list.Where(x => x.ID == Convert.ToInt32(MD.ID)).FirstOrDefault();

            if (medicine == null)
            {
                medicine = new Medicine()
                {
                    ID = list.Count + 1,
                    Name = MD.Name,
                    Brand = MD.Brand,
                    ExpiryDate = DateTime.Now.AddDays(100),
                    Price = MD.Price,
                    Quantity = MD.Quantity

                };
                list.Add(medicine);
            }
            else
            {
                medicine.Name = MD.Name;
                medicine.Brand = MD.Brand;
                medicine.Quantity = MD.Quantity;
            }

            Session["list"] = list;
            //string result = objDB.UpdateData(MD); // passing Value to DBClass from model
            //ViewData["resultUpdate"] = result; // for dislaying message after saving storing output.
            return RedirectToAction("Index", "Home");

        }
        private void GetData()
        {
            list = Session["list"] as List<Medicine>;

            if (list == null)
            {
                list = new List<Medicine>();
            }

            if (list.Count > 0)
            {
                return;
            }

            var medicine = new Medicine()
            {
                ID = 1,
                Name = "Medicine 1",
                Brand = "Brand 1",
                ExpiryDate = DateTime.Now.AddDays(100),
                Price = 233,
                Quantity = 2

            };
            list.Add(medicine);

            medicine = new Medicine()
            {
                ID = 2,
                Name = "Medicine 2",
                Brand = "Brand 2",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);

            medicine = new Medicine()
            {
                ID = 3,
                Name = "Medicine 3",
                Brand = "Brand 3",
                ExpiryDate = DateTime.Now.AddDays(50),
                Price = 52,
                Quantity = 7

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 4,
                Name = "Medicine 4",
                Brand = "Brand 4",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 5,
                Name = "Medicine 5",
                Brand = "Brand 5",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 6,
                Name = "Medicine 6",
                Brand = "Brand 6",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 7,
                Name = "Medicine 7",
                Brand = "Brand 7",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 8,
                Name = "Medicine 8",
                Brand = "Brand 8",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 9,
                Name = "Medicine 9",
                Brand = "Brand 9",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 10,
                Name = "Medicine 10",
                Brand = "Brand 10",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);
            medicine = new Medicine()
            {
                ID = 11,
                Name = "Medicine 11",
                Brand = "Brand 11",
                ExpiryDate = DateTime.Now.AddDays(200),
                Price = 32,
                Quantity = 4

            };
            list.Add(medicine);

            Session["list"] = list;
            //return list;


        }
    }
}