using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreRepositoryPattern.Repository.Abstract
{
  public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        T Update(T entity);
        int Delete(T entity);
        T Insert(T entity);
    }
}
