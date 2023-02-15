using Entity.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly db_a947e4_soleauthenticitydbContext _dbContext;

        public CommentRepository(db_a947e4_soleauthenticitydbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
