﻿using Entity.Models;
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
        private readonly db_a947e4_soleauthenticitydbContext _dbContext;

        public OrderDetailRepository(db_a947e4_soleauthenticitydbContext dbContext) : base(dbContext)
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
