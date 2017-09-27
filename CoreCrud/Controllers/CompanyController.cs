using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCrud.Service;
using CoreCrud.Models;
using System.IO;
using CoreCrud.Data;

namespace CoreCrud.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        public IActionResult Index()
        {
            List<CompanyViewModel> model = new List<CompanyViewModel>();
            model = this.companyService.GetCompanies().Select(x => new CompanyViewModel()
            {
                Address = x.Address,
                CompanyName = x.CompanyName,
                Id = x.Id
            }).ToList();
            return View(model);
        }
        public IActionResult GetCompanyInfo(int id)
        {
            CompanyViewModel model = null;
            if (id > 0)
            {
                Company comp = companyService.Get(id);
                if (comp != null)
                {
                    model = new CompanyViewModel()
                    {
                        Address = comp.Address,
                        Id = comp.Id,
                        CompanyName = comp.CompanyName
                    };

                }
            }
            return PartialView("_CompanyModel", model);
        }
        public ActionResult DeleteCompany(int id)
        {
            CompanyViewModel model = new CompanyViewModel();
            Company comp = companyService.Get(id);
            if (comp != null)
            {
                model = new CompanyViewModel()
                {
                    Address = comp.Address,
                    Id = comp.Id,
                    CompanyName = comp.CompanyName
                };

            }
            return PartialView("_DeleteCompany", model);
        }
    }
}