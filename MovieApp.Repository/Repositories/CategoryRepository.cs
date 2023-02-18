using MovieApp.Core.Repository;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Repository.Repositories
{
    public class CategoryRepository :GenericRepository<Category>, ICategoryRepository
    {
    }
}
