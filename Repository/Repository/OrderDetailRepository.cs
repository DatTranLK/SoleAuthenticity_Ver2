using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly db_a971f8_soleauthenticityContext _dbContext;

        public OrderDetailRepository(db_a971f8_soleauthenticityContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderDetail> GetOrderDetailByOrderId(int orderId)
        {
            try
            {
                var od = await _dbContext.OrderDetails.FirstOrDefaultAsync(x => x.OrderId == orderId);
                if (od == null)
                {
                    return null;
                }
                return od;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
