﻿using System.Linq.Expressions;

namespace ECommerce.Services.Order.Application.Interfaces
{
	public interface IRepository<T> where T : class
    {
		Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
		Task CreateAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(int id);
		Task<T> GetOrdersByFilter(Expression<Func<T, bool>> filter);
	}
}