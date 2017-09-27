using System;
using System.Collections.Generic;
using System.Text;
using CoreCrud.Data;
using CoreCrud.Repository;

namespace CoreCrud.Service
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository<Company> companyRepository;
        public CompanyService(ICompanyRepository<Company> companyRepository)
        {
            this.companyRepository = companyRepository;

        }
        public bool AddCompany(Company company)
        {

            return companyRepository.Insert(company);
        }
        public bool Update(Company company)
        {
            return companyRepository.Update(company);
        }

        public Company Get(int id)
        {
            return companyRepository.Get(id);
        }

        public List<Company> GetCompanies()
        {
            return this.companyRepository.GetCompanies();
        }

        public bool Remove(int id)
        {
            return companyRepository.Remove(id);
        }
    }
}
