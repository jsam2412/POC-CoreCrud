using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreCrud.Service;
using CoreCrud.Models;
using CoreCrud.Data;

namespace CoreCrud.Controllers.api
{
   
    public class companyAPIController : Controller
    {
        private readonly ICompanyService companyService;
        public companyAPIController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [Route("api/company/Edit")]
        public ResponseMessage<bool> EditCompany(CompanyViewModel model)
        {
            ResponseMessage<bool> response = new ResponseMessage<bool>();
            if (model != null && model.Id > 0)
            {
                var comp = new Company()
                {
                    Address = model.Address,
                    Id = model.Id,
                    CompanyName = model.CompanyName
                };
                if (companyService.Update(comp))
                {
                    response.Status = true;
                    response.Body = true;
                }
                else
                {
                    response.Status = false;
                    response.Body = false;
                }

            }
            else
            {
                response.Status = false;
                response.Body = false;
                response.Message = "Model can not be null";
            }
            return response;
        }
        [Route("api/company/remove")]
        public ResponseMessage<bool> DeleteCompany(int id)
        {
            ResponseMessage<bool> response = new ResponseMessage<bool>();
            if (id > 0)
            {
                if (companyService.Remove(id))
                {
                    response.Status = true;
                    response.Body = true;
                }
                else
                {
                    response.Status = false;
                    response.Body = false;
                }
            }
            else
            {
                response.Status = false;
                response.Body = false;
                response.Message = "Id can not be null";
            }
            return response;
        }
    }
}