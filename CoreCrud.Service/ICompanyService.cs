using CoreCrud.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCrud.Service
{
    public interface ICompanyService
    {
        bool AddCompany(Company company);
        bool Update(Company company);
        Company Get(int id);
        List<Company> GetCompanies();
        bool Remove(int id);
    }
}
