using CoreCrud.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCrud.Repository
{
    public class CompanyRepository<T> : ICompanyRepository<T> where T : Company
    {
        private readonly ApplicationContext context;
        //   private DbSet<T> entities;
        private DbSet<T> entities;
        public CompanyRepository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void AddCompany(T company)
        {
            entities.Add(company);
        }
        public T Get(int id)
        {
            return entities.FirstOrDefault(s => s.Id == id);
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetCompanies()
        {
            return entities.AsEnumerable().ToList();
        }

        public bool Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
            return true;
        }

        public bool Remove(int id)
        {
            var entity = entities.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return false;
            }

            entities.Remove(entity);
            context.SaveChanges();
            return true;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public bool Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            var company = entities.FirstOrDefault(s => s.Id == entity.Id);
            company.Address = entity.Address;
            company.CompanyName = entity.CompanyName;
            context.SaveChanges();
            return true;
        }
    }
}
