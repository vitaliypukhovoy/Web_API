using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vote_WebAPI_.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Vote_WebAPI_.DAL
{
    public class Repository<T>:IRepository<T> where T: class
    {
         private ContexDB m_context = null;
         DbSet<T> m_DbSet;
        public Repository(ContexDB context)
        {
            m_context = context;
            m_DbSet = m_context.Set<T>(); 
        }
        public  IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return m_DbSet.Where(predicate);            
            }
            return m_DbSet.AsEnumerable();
        }
         public T Get(Expression<Func<T, bool>> predicate = null)
        {
            return m_DbSet.FirstOrDefault(predicate);              
        }
        public void Add(T entity)
        {
            m_DbSet.Add(entity);
        }
        public void Udate(T entity)
        {
            m_DbSet.Attach(entity);
            ((IObjectContextAdapter)m_context).ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
        }

        public void Delete(T entity)
        {
             m_DbSet.Remove(entity);        
        }

        public long Count()
        {
            return m_DbSet.Count();                              
        }

    }
}