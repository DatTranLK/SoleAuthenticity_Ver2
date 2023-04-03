using Entity.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ShoeCheckRepository : GenericRepository<ShoeCheck>, IShoeCheckRepository
    {
        private readonly db_a971f8_soleauthenticityContext _dbContext;

        public ShoeCheckRepository(db_a971f8_soleauthenticityContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
