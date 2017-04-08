using DotNetCoreRepositoryPattern.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using DotNetCoreRepositoryPattern.Models.Domain.Model;
using DotNetCoreRepositoryPattern.Models.Infrastructure.Data;
using System.Linq;

namespace DotNetCoreRepositoryPattern.Repository.Concrete
{
    public class UserRepository : BaseRepository, IUserRepository 
    {
        private readonly UniversityContext _dbContext;

        public UserRepository(UniversityContext context)
        {
            this._dbContext = context;
        }

        public int Delete(User entity)
        {
            _dbContext.Set<User>().Remove(entity);
            int a=_dbContext.SaveChanges();
            return a;

        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            return _dbContext.Set<User>();
        }

        public User Insert(User entity)
        {
            _dbContext.Set<User>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
