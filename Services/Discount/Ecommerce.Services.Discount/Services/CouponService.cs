using Dapper;
using Ecommerce.Services.Discount.Context;
using Ecommerce.Services.Discount.DTOs;

namespace Ecommerce.Services.Discount.Services
{
    public class CouponService : ICouponService
    {
        private readonly DapperContext _context;

        public CouponService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateCouponAsync(CreateCouponDTO createCouponDTO)
        {
            string query = "Insert Into Coupons (Code, Rate, IsActive, ValidDate) Values (@code, @rate, @isActive, @validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDTO.Code);
            parameters.Add("@rate", createCouponDTO.Rate);
            parameters.Add("@isActive", true);
            parameters.Add("@validDate", DateTime.Now.AddDays(10));
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "Delete From Coupons Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<ResultCouponDTO> GetCouponByIdAsync(int id)
        {
            string query = "Select * From  Coupons Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ResultCouponDTO>(query, parameters);
                return values;
            }
        }

        public async Task<List<ResultCouponDTO>> GetAllCouponsAsync()
        {
            string query = "Select * From Coupons";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCouponDTO>(query);
                return values.ToList();
            }
        }

        public async Task UpdateCouponAsync(UpdateCouponDTO updateCouponDTO)
        {
            string query = "Update Coupons Set Code=@code, Rate=@rate, IsActive=@isActive, ValidDate=@validDate Where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDTO.Code);
            parameters.Add("@rate", updateCouponDTO.Rate);
            parameters.Add("@isActive", updateCouponDTO.IsActive);
            parameters.Add("@validDate", updateCouponDTO.ValidDate);
            parameters.Add("@couponID", updateCouponDTO.CouponID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}