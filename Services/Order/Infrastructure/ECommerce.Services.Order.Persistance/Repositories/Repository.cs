﻿using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.Services.Order.Persistance.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly OrderContext _context;

		public Repository(OrderContext context)
		{
			_context = context;
		}

		public async Task CreateAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(T entity)
		{
			_context.Set<T>().Remove(entity);
			await _context.SaveChangesAsync();
		}
		
		public async Task<List<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}
		
		public async Task<T> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}
		
		public async Task<T> GetOrdersByFilter(Expression<Func<T, bool>> filter)
		{
			return await _context.Set<T>().SingleOrDefaultAsync(filter);
		}

		public async Task UpdateAsync(T entity)
		{
			_context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}