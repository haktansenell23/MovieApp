using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Core.Repository
{
    public  interface IGenericRepository<T> where T:BaseEntity
    {
        public Task<T> GetByIdAsync(string id); 
         
        public Task<T>AddAsync(T entity);   

        public Task<List<T>>AddAllAsync(List<T> entities);  

        public void UpdateAsync(T entity);

        public IQueryable GetAll();       

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression);    

        public IQueryable Where(Expression<Func<T, bool>> expression);

       public void Delete(T entity);    

        public void DeleteAllAsync(List<T> entities);   


    }
}
