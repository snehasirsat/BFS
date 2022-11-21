using BFS.Models;
using DbLibraries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BFS.Controllers
{
    public class AccountMasterController : Controller
    {
        EDB<FIS_AccountMaster> accountmaster = new EDB<FIS_AccountMaster>();
        ICommon _C;
        // GET: AccountMasterController
        public AccountMasterController(ICommon c)
        {
            _C = c;
        }
        public ActionResult Index()
        {
            return View(accountmaster.Data.ToList());
        }

        // GET: AccountMasterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountMasterController/Create
        public ActionResult Create()
        {
            FIS_AccountMaster AccountMaster = new FIS_AccountMaster();
            if (accountmaster.Data.Count()>0)
                AccountMaster.AccountID = accountmaster.Data.ToList().Max(e => e.ClientID) + 1;
            else
                AccountMaster.AccountID = 1;

            return View(AccountMaster);
        }

        // POST: AccountMasterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                FIS_AccountMaster a = new FIS_AccountMaster();
                a.AccountID = accountmaster.Data.Count();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountMasterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountMasterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountMasterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountMasterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
