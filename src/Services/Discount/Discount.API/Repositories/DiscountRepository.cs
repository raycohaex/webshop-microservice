using Discount.API.Data;
using Discount.API.Entities;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Discount.API.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly DiscountContext _context;

        public DiscountRepository(DiscountContext context)
        {
            _context = context;
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            return await _context.Coupons.FindAsync(productName);
        }

        public Task<bool> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
