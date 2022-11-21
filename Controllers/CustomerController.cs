using BFS.Models;
using DbLibraries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace BFS.Controllers
{
    public class CustomerController : Controller
    {
       EDB<FIS_Customer> customer = new EDB<FIS_Customer>();
        ICommon _C;
        public CustomerController(ICommon C)
        {
            _C = C;
        }
        // GET: Customer
        public ActionResult Index()
        {
            //List<FIS_Customer> elist = customer.Data.ToList();
            return View(customer.Data.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(customer.Data.ToList().Find(e => e.ClientID == id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            FIS_Customer fiscustomer = new FIS_Customer();
            if (customer.Data.Count() > 0)
                fiscustomer.ClientID = customer.Data.ToList().Max(e => e.ClientID) + 1;
            else
                fiscustomer.ClientID = 1;

            return View(fiscustomer);
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                FIS_Customer c = new FIS_Customer();
                c.ClientID = _C.cInt(collection["ClientID"]);
                c.ClientName = collection["ClientName"];
                c.ClientType = collection["ClientType"];
                c.Address_1 = collection["Address_1"];
                c.Address_2 = collection["Address_2"];
                c.City = collection["City"];
                c.District = collection["District"];
                c.State = collection["State"];
                c.MobileNumber = collection["MobileNumber"];
                c.AadharNo = collection["AadharNo"];
                c.PAN = collection["PAN"];
                c.Telephone = collection["Telephone"];
                c.Email = collection["Email"];
                c.Gender = collection["Gender"];
                //c.Photo = Convert.ToByte(collection["Photo"]);
                //c.Signature = Convert.ToByte(collection["Signature"]);
                c.IsActive = "Y";
                customer.Add(c);
                customer.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            FIS_Customer c = customer.Data.ToList().Find(e => e.ClientID == id);            
            return View(c);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                FIS_Customer c = new FIS_Customer();
                c.ClientID = _C.cInt(collection["ClientID"]);
                c.ClientName = collection["ClientName"];
                c.ClientType = collection["ClientType"];
                c.Address_1 = collection["Address_1"];
                c.Address_2 = collection["Address_2"];
                c.City = collection["City"];
                c.District = collection["District"];
                c.State = collection["State"];
                c.MobileNumber = collection["MobileNumber"];
                c.AadharNo = collection["AadharNo"];
                c.PAN = collection["PAN"];
                c.Telephone = collection["Telephone"];
                c.Email = collection["Email"];
                c.Gender = collection["Gender"];
                //c.Photo = Convert.ToByte(collection["Photo"]);
                //c.Signature = Convert.ToByte(collection["Signature"]);
                c.IsActive = "Y";
                customer.Update(c);
                customer.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(customer.Data.ToList().Find(e=>e.ClientID==id));
        }

        // POST: Customer/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                FIS_Customer c = new FIS_Customer();
                c.ClientID = id;
                customer.Remove(c);
                customer.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
