using Entity.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly db_a947e4_soleauthenticitydbContext _dbContext;

        public CategoryRepository(db_a947e4_soleauthenticitydbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
