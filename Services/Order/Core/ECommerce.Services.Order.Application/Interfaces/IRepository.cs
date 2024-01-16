using System.Linq.Expressions;

namespace ECommerce.Services.Order.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
        Task<List<T>> GetFilteredList(Expression<Func<T, bool>> filter);
    }
}