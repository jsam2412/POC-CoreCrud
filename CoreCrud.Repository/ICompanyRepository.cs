using CoreCrud.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCrud.Repository
{
    public interface ICompanyRepository<T> where T : Company
    {
        T Get(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Remove(int id);
        void SaveChanges();
        List<T> GetCompanies();
    }
}
